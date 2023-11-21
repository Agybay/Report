using DocumentFormat.OpenXml.Wordprocessing;
using OpenCity.Report.Application.Services;

namespace OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter {
    /// <summary>
    /// Программа форматирования полного имени сотрудника
    /// </summary>
    public class EmployeeFullnameFormatter : ICoverLetterFormatter<string> {
        public string Parameter { get; set; }
        public EmployeeFullnameFormatter(string tr) {
            Parameter = tr;
        }
        public void Execute(Document documentx) {
            if(!string.IsNullOrEmpty(Parameter)) {
                foreach(var text in documentx.Descendants<Text>()) {
                    if(text.Text.Contains("SIGNEDNAME"))
                        text.Text = text.Text.Replace("SIGNEDNAME", Parameter);
                }
            }
        }
    }
}
