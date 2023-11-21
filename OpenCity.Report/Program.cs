using MassTransit;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using OpenCity.Domain;
using OpenCity.Report;
using OpenCity.Report.Application.Bindings;
using OpenCity.Report.Application.Services;
using OpenCity.Report.Consumer;
using OpenCity.Report.Infrastructure.Impl;
using OpenCity.Report.Infrastructure.Impl.BackgroundJobs;
using OpenCity.Report.Infrastructure.Impl.Services;
using Quartz;
using Refit;
using Serilog;
using System.Reflection;
using System.Runtime.InteropServices;

var appName = Assembly.GetExecutingAssembly().GetName().Name;
try {
    var builder = WebApplication.CreateBuilder(args);
    builder.Host.UseSerilog((context, services, configuration) => configuration
           .ReadFrom.Configuration(context.Configuration)
           .Enrich.WithProperty("app-name", appName)
           .ReadFrom.Services(services)
           .Enrich.FromLogContext());

    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(
        c => {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Report Service", Version = "v1" });
            c.EnableAnnotations();
            c.SupportNonNullableReferenceTypes();
        }
    );
   
    var fileStorageEndPoint = (Uri)builder.Configuration.GetValue(typeof(Uri), "FileStorageEndPoint");
    var refitSettings = new RefitSettings {
        ContentSerializer = new CustomContentSerializer()
    };
    builder.Services.AddRefitClient<IFileStorageService>(refitSettings)
   .ConfigureHttpClient(c => c.BaseAddress = fileStorageEndPoint);

    builder.Services.AddQuartz(configure => {
        var jobKey = new JobKey(nameof(ProcessOutboxMessagesJob));
        configure
            .AddJob<ProcessOutboxMessagesJob>(jobKey)
            .AddTrigger(trigger =>
                trigger.ForJob(jobKey)
            .WithSimpleSchedule(schedule =>
                schedule.WithIntervalInSeconds(40)
            .RepeatForever()));
        configure.UseMicrosoftDependencyInjectionJobFactory();
    });
    builder.Services.AddQuartzHostedService();

    builder.Services.AddScoped<IGenerateDocument, GenerateDocument>();
    builder.Services.AddDataAccessPostgreSql(builder.Configuration);
    builder.Services.AddScoped<ReportByteDataExtractor>();
    builder.Services.AddScoped<IDocumentAction, CoverLetterDbManager>();

    #region rabbitMq
    builder.Services.Configure<RabbitMqOptions>(options => builder.Configuration.GetSection("RabbitMq").Bind(options));
    builder.Services.AddSingleton(x => x.GetService<IOptions<RabbitMqOptions>>().Value);
    builder.Services.AddMassTransit(x => {
        x.AddDelayedMessageScheduler();
        x.SetKebabCaseEndpointNameFormatter();
        x.AddConsumer<CreateDocumentConsumer>();
        x.UsingRabbitMq((context, cfg) => {
            var rabbit = context.GetRequiredService<RabbitMqOptions>();
            var rabbitHost = new Uri(new Uri($"rabbitmq://{rabbit.MainHost}"), rabbit.VirtualHost);
            cfg.Host(rabbitHost, $"{appName}", h => {
                h.Username(rabbit.UserName);
                h.Password(rabbit.Password);
                h.UseCluster(c => Array.ForEach(rabbit.HostNames, c.Node));
            });
            cfg.ConfigureEndpoints(context);
        });
    });
    #endregion
    if(!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
        DevExpress.Drawing.Internal.DXDrawingEngine.ForceSkia();
    }
    var app = builder.Build();
    app.UseStaticFiles();

    #region rabbitMq
    var busControl = app.Services.GetService<IBusControl>();
    app.Lifetime.ApplicationStarted.Register(busControl.Start);
    app.Lifetime.ApplicationStopped.Register(busControl.Stop);
    #endregion


    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
    app.MapControllers();

    app.Run();

}
catch(Exception ex) {
    Log.Fatal(ex, "OpenCity.Report.Api stopped");
    throw;
}
finally {
    Log.Information("Log Complete");
    Log.CloseAndFlush();
}
