using CSharpFunctionalExtensions;
using DevExpress.XtraPrinting;

namespace OpenCity.Report.Infrastructure.Impl {
    public class ReportByteDataExtractor {
        public async Task<Result<byte[]>> Get(ReportAssemblyModel assemblyModel) {
            var title = assemblyModel.GetReportName();
            var report = assemblyModel.GetTemplate();
            assemblyModel.PrepareModelForBinding();
            using(var ms = new MemoryStream()) {
                var exportOptions = new PdfExportOptions {
                    DocumentOptions = {
                        Title = title,
                    }
                };
                report.DataSource = new[] { assemblyModel };
                await report.ExportToPdfAsync(ms, exportOptions);
                return Result.Success(ms.ToArray());
            }
        }
    }
}
