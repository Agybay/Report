using OpenCity.Report.Contracts;

namespace OpenCity.Domain.Entities {
    public class OutboxMessage {
        public Guid Id { get; set; }
        public Guid DocumentId { get; set; }
        public ReportType ReportType { get; set; }
        public Guid ApplicationId { get; set; }
        public CoverLetterCondition? CoverLetterCondition { get; set; } = null;
        public string DocumentMimeType { get; set; }
        public Guid CorrelationId { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Processed { get; set; }
        public string? Error { get; set; }
    }
}
