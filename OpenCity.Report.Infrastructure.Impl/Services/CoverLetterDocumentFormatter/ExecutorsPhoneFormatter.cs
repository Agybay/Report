using DocumentFormat.OpenXml.Wordprocessing;
using OpenCity.Report.Application.Services;

namespace OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter {
    /// <summary>
    /// Форматирование телефона исполнителей
    /// </summary>
    public class ExecutorsPhoneFormatter : ICoverLetterFormatter<string[]> {
        public string[] Parameter { get; set; }

        public ExecutorsPhoneFormatter(string[] tr) {
            Parameter = tr;
        }

        public void Execute(Document documentx) {
            foreach(var text in documentx.Descendants<Text>()) {
                if(text.Text.Contains("EXECPHONE")) {
                    text.Text = text.Text.Replace("EXECPHONE",
                        Parameter.Length > 0
                            ? Parameter.Aggregate((i, e) => i + " , " + e)
                            : " ");
                }
            }
        }
    }
}
