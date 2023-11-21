using DocumentFormat.OpenXml.Wordprocessing;
using OpenCity.Report.Application.Extensions;
using OpenCity.Report.Application.Services;

namespace OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter {
    /// <summary>
    ///Форматирование исполнителя
    /// </summary>
    public class ExecutorFormatter : ICoverLetterFormatter<string> {
        public string Parameter { get; set; }

        public ExecutorFormatter(string fullName) {
            Parameter = fullName.FullNameToAbbreviated();
        }


        public void Execute(Document documentx) {
            foreach(var text in documentx.Descendants<Text>()) {
                if(text.Text.Contains("EXECUTOR")) {
                    text.Text = text.Text.Replace("EXECUTOR",
                        Parameter);
                }
            }

        }
    }
}
