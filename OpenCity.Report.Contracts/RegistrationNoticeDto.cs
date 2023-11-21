using System;

namespace OpenCity.Report.Contracts {
    public class RegistrationNoticeDto {
        public string ApplicantNameOrOrganizaionName { get; set; }
        public DateTime Date { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
