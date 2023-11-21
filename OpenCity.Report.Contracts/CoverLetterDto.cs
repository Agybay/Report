using System.Data;

namespace OpenCity.Report.Contracts {
    public class CoverLetterDto {
        public string ApplicantTypeCode { get; set; }
        public (string, string) ExecutorOrganization { get; set; }
        public string ApplicationNumber { get; set; }
        public string ApplicantFullName { get; set; }
        public string ApplicantOrganizationName { get; set; }
        public string ExecutorTelephoneNumber { get; set; }
        public string ExecutorFullName { get; set; }
    }
}
