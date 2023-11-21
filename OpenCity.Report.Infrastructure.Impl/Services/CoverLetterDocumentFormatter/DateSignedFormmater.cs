using DocumentFormat.OpenXml.Wordprocessing;
using OpenCity.Report.Application.Services;

namespace OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter {
    public class DateSignedFormmater : ICoverLetterFormatter<string> {
        public string Parameter { get; set; }
        public DateSignedFormmater(string tr) {
            Parameter = tr;
        }
        public void Execute(Document documentx) {
            if(!string.IsNullOrEmpty(Parameter)) {
                foreach(var text in documentx.Descendants<Text>()) {
                    if(text.Text.Contains("DATETIME"))
                        text.Text = text.Text.Replace("DATETIME", Parameter);
                }
            }
        }
    }
}
