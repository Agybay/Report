using DevExpress.XtraReports.UI;

namespace OpenCity.Report.Infrastructure.Impl.Models {
    public class ApplicationCardPortalModel : ReportAssemblyModel {
        public string ApplicantNameOrOrganizaionName { get; set; }
        public string Date { get; set; }
        public string Xin { get; set; }
        public string AddressKk { get; set; }
        public string AddressRu { get; set; }
        public string TelephonNumber { get; set; }
        public string QRKk { get; set; }
        public string QRRu { get; set; }
        public string ApplicationText { get; set; }
        public string SignKk { get; set; } = null;
        public string SignRu { get; set; } = null;
        public string ApplicationNumber { get; set; }
        public override string ReportName { get; set; } = "Карточка обращения";

        public override XtraReport GetTemplate() {
            return new Templates.ApplicationCardPortal();
        }

        public override void PrepareModelForBinding() {
            QRKk = $"ТӘЖ: {ApplicantNameOrOrganizaionName} \r\n ЖСН: {Xin} \r\n Телефон нөмірі: {TelephonNumber} \r\n Өтініш нөмірі: {ApplicationNumber}";
            QRRu = $"ФИО: {ApplicantNameOrOrganizaionName} \r\n ИИН: {Xin} \r\n Телефон: {TelephonNumber} \r\n Номер заявки: {ApplicationNumber}";
        }
    }
}
