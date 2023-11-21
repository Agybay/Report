using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using OpenCity.Domain.Context;

namespace OpenCity.Domain {
    public static class DependencyInjection {
        public static void AddDataAccessPostgreSql(this IServiceCollection services, IConfiguration configuration) {
            var datasourceBuilder = new NpgsqlDataSourceBuilder(configuration["PostgreDb:DefaultConnectionString"]);
            var datasource = datasourceBuilder.Build();
            services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(datasource), ServiceLifetime.Transient);
        }
    }
}
