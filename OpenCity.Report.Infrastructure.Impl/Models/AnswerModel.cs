using DevExpress.XtraReports.UI;
using OpenCity.Report.Infrastructure.Impl.Templates;

namespace OpenCity.Report.Infrastructure.Impl.Models {
    public class AnswerModel : ReportAssemblyModel {
        public string ApplicationNumber { get; set; }
        public string AnswerText { get; set; }
        public override string ReportName { get; set; } = "Ответ от ИО";
        public override XtraReport GetTemplate() {
            return new AnswerFromIO();
        }
        
        public override void PrepareModelForBinding() {
        }
    }
}
