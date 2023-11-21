using DevExpress.XtraReports.UI;

namespace OpenCity.Report.Infrastructure.Impl.Models {
    public class ApplicationCardModel : ReportAssemblyModel {
        public string? ApplicantNameOrOrganizaionName { get; set; }
        public string Date { get; set; }
        public string? Xin { get; set; }
        public string? AddressRu { get; set; }
        public string? AddressKk { get; set; }
        public string? TelephonNumber { get; set; }
        public string? ApplicationSourceCode { get; set; }
        public string ApplicationTypeRu { get; set; }
        public string ApplicationTypeKk { get; set; }
        public string ApplicationText { get; set; }
        public string BodyRu { get; set; }
        public string BodyKk { get; set; }
        public string SignKk { get; set; } = null;
        public string SignRu { get; set; } = null;
        public string SignDate { get; set; } = null;
        public override string ReportName { get; set; } = "Карточка обращения";
        public override XtraReport GetTemplate() {
            return new Templates.ApplicationCard();
        }

        public override void PrepareModelForBinding() {

            if(ApplicationSourceCode == "FrontOffice") {
                BodyKk = "Менің сөзімнен дұрыс жазылған, менімен оқылған, толықтыруларым жоқ.";
                BodyRu = "С  моих  слов  записано  верно,  мною  прочитано, дополнений не имею.";
                SignKk = $"Қолы  ___________________";
                SignRu = $"Подпись  ___________________";
                SignDate = DateTime.Now.ToString("dd.MM.yyyy");
            }
        }
    }
}
