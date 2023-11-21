namespace OpenCity.Report.Contracts {
    public class CreateDocument {
        public ReportType ReportType { get; set; }
        public string Content { get; set; }// serialization js
        public Guid ApplicationId { get; set; }
        public Guid CorrelationId { get; set; }
    }
}
