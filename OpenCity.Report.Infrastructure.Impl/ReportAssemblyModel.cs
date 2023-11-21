using DevExpress.XtraReports.UI;

namespace OpenCity.Report.Infrastructure.Impl {
    public abstract class ReportAssemblyModel {
        protected string ReportType { get; set; }
        public virtual string ReportName { get; set; }
        public string Uid { get; set; } = Guid.NewGuid().ToString("N");

        public virtual string GetReportName() {
            return !string.IsNullOrEmpty((ReportName + "").Trim()) ? ReportName : ReportType ?? throw new ArgumentException("Тип \"отчета\" не задан");
        }

        public abstract XtraReport GetTemplate();
        public abstract void PrepareModelForBinding();
    }
}
