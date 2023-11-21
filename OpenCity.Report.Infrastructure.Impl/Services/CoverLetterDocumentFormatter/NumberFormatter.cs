using DocumentFormat.OpenXml.Wordprocessing;
using OpenCity.Report.Application.Services;

namespace OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter {
    /// <summary>
    /// Программа форматирования чисел
    /// </summary>
    public class NumberFormatter : ICoverLetterFormatter<string> {
        public string Parameter { get; set; }

        public NumberFormatter(string tr) {
            Parameter = tr;
        }
        public void Execute(Document documentx) {
            foreach(var text in documentx.Descendants<Text>()) {
                if(text.Text.Contains("NUMBER")) {
                    text.Text = text.Text.Replace("NUMBER", Parameter);
                }
            }
        }
    }
}
