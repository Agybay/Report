using DocumentFormat.OpenXml.Wordprocessing;
using OpenCity.Report.Application.Services;

namespace OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter {
    /// <summary>
    /// Форматирования полного имени
    /// </summary>
    public class FullNameFormatter : ICoverLetterFormatter<string> {
        public FullNameFormatter(string tr) {
            Parameter = tr;
        }
        public string Parameter { get; set; }

        public void Execute(Document documentx) {
            foreach(var text in documentx.Descendants<Text>()) {
                if(text.Text.Contains("FULLNAME"))
                    text.Text = text.Text.Replace("FULLNAME", Parameter);
            }
        }
    }
}
