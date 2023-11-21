namespace OpenCity.Report.Contracts {
    public class ResponseDocument {
        public ReportType ReportType { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid CorrelationId { get; set; }
        public Guid DocumentId { get; set; }
        public string MimeType { get; set; } = string.Empty;
        public CoverLetterCondition? ReportState { get; set; }
    }
}
