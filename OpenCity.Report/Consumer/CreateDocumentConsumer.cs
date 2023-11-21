using MassTransit;
using OpenCity.Domain.Context;
using OpenCity.Domain.Entities;
using OpenCity.Report.Application.Services;
using OpenCity.Report.Contracts;

namespace OpenCity.Report.Consumer {
    public class CreateDocumentConsumer : IConsumer<CreateDocument> {
        private readonly ILogger<CreateDocumentConsumer> _logger;
        private readonly IGenerateDocument _generateDocument;
        private readonly ApplicationContext _context;

        public CreateDocumentConsumer(ILogger<CreateDocumentConsumer> logger,
            IGenerateDocument generateDocument,
            ApplicationContext context) {
            _logger = logger;
            _generateDocument = generateDocument;
            _context = context;
        }

        public async Task Consume(ConsumeContext<CreateDocument> context) {
            try {
                var message = context.Message;
                
                if (message is null) {
                    throw new ArgumentNullException(nameof(message));
                }

                _logger.Log(LogLevel.Information, $"Create Document Consumer ApplicationID = {message.ApplicationId} " + message.Content);

                var result = message.ReportType switch {
                    ReportType.ApplicationCardPortal => await _generateDocument.ApplicationPortalCardAsync(message),
                    ReportType.ApplicationCard => await _generateDocument.ApplicationCardAsync(message),
                    ReportType.Answer => await _generateDocument.Answer(message),
                    ReportType.AddQrToCoverLetter => await _generateDocument.AddQrToCoverLetter(message),
                    ReportType.CoverLetter => await _generateDocument.CoverLetter(message),
                    ReportType.RegistrationNotice => await _generateDocument.RegistrationNoticeAsync(message),
                    _ => (ResponseDocument?) null
                }; 

                if(result is null) {
                    return;
                }

                var outbox = new OutboxMessage {
                    ApplicationId = result.ApplicationId,
                    CorrelationId = result.CorrelationId,
                    CoverLetterCondition = result.ReportState,
                    DocumentId = result.DocumentId,
                    ReportType = result.ReportType,
                    DocumentMimeType = "pdf"
                };

                await _context.OutboxMessages.AddAsync(outbox);
                await _context.SaveChangesAsync();

            }
            catch(Exception ex) {
                _logger.LogError(ex, "Problem with creating Create Document");
            }
        }
    }
}
