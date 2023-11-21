using DocumentFormat.OpenXml.Wordprocessing;
using OpenCity.Report.Application.Services;

namespace OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter {
    /// <summary>
    /// Исполнительный Орган
    /// </summary>
    public class ExecutorOrganizationFormatter : ICoverLetterFormatter<(string, string)> {
        public ExecutorOrganizationFormatter((string, string) parameter) {
            Parameter = parameter;
        }

        public (string, string) Parameter { get; set; }

        public void Execute(Document documentx) {
            if(Parameter.Item1 != null) {
                var item = documentx.Descendants<Text>().ToArray();
                for(int i = 0; i < item.Length; i++) {
                    if(item[i].Text.Contains("RU")) {
                        item[i].Text = item[i].Text.Replace("RU", Parameter.Item1);
                    }
                    if(item[i].Text.Contains("KK")) {
                        item[i].Text = item[i].Text.Replace("KK", Parameter.Item2);
                    }
                }
            }
            else {
                var item = documentx.Descendants<Text>().ToArray();
                for(int i = 0; i < item.Length; i++) {
                    if(item[i].Text.Contains("RU")) {
                        item[i].Text = item[i].Text.Replace("RU", " ");
                    }
                    if(item[i].Text.Contains("KK")) {
                        item[i].Text = item[i].Text.Replace("KK", " ");
                    }
                }
            }
        }
    }
}
