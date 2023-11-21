using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OpenCity.Report.Application.Services;

namespace OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter {
    /// <summary>
    /// Форматирование подписанного заголовка и нижнего колонтитула
    /// </summary>
    public class SignedHeaderFooterFormatter : ICoverLetterFormatter<string> {
        public string Parameter { get; set; }
        public bool IsSigned { get; set; }
        public string SignedBy { get; set; }
        public DateTime SignedDate { get; set; }

        public SignedHeaderFooterFormatter(bool isSigned, string signedBy, DateTime signedDate) {
            IsSigned = isSigned;
            SignedBy = signedBy;
            SignedDate = signedDate;
        }

        public void Execute(Document documentx) {
            if(!IsSigned) return;

            // Get the main document part
            var mainDocumentPart = documentx.MainDocumentPart;

            // Delete the existing header and footer parts
            mainDocumentPart.DeleteParts(mainDocumentPart.HeaderParts);
            mainDocumentPart.DeleteParts(mainDocumentPart.FooterParts);

            // Create a new header parts
            var headerPartOdd = mainDocumentPart.AddNewPart<HeaderPart>();
            var headerPartEven = mainDocumentPart.AddNewPart<HeaderPart>();

            // Create a new footer parts
            var footerPartOdd = mainDocumentPart.AddNewPart<FooterPart>();
            var footerPartEven = mainDocumentPart.AddNewPart<FooterPart>();

            // Get Id of the header parts
            string headerPartIdOdd = mainDocumentPart.GetIdOfPart(headerPartOdd);
            string headerPartIdEven = mainDocumentPart.GetIdOfPart(headerPartEven);

            // Get Id of the footer parts
            string footerPartIdOdd = mainDocumentPart.GetIdOfPart(footerPartOdd);
            string footerPartIdEven = mainDocumentPart.GetIdOfPart(footerPartEven);

            //Generate headers
            var runOddHeader = new Run(
                new RunProperties(
                    new RunFonts { Ascii = "Times New Roman", ComplexScript = "Times New Roman", EastAsia = "Times New Roman", HighAnsi = "Times New Roman" },
                    new FontSize { Val = new StringValue("22") }
                ),
                new Text(string.Format("Қол қойылды: {0} ; Күні: {1}", SignedBy, SignedDate)));
            headerPartOdd.Header = new Header(new Paragraph(
                new ParagraphProperties(new Justification() { Val = JustificationValues.Center }),
                runOddHeader));

            var runEvenHeader = new Run(
                new RunProperties(
                    new RunFonts { Ascii = "Times New Roman", ComplexScript = "Times New Roman", EastAsia = "Times New Roman", HighAnsi = "Times New Roman" },
                    new FontSize { Val = new StringValue("22") }
                ),
                new Text(string.Format("Подписал: {0} ; Дата: {1}", SignedBy, SignedDate))
            );
            headerPartEven.Header = new Header(new Paragraph(
                new ParagraphProperties(new Justification() { Val = JustificationValues.Center }),
                runEvenHeader));

            //Generate footers
            var runOddFooter = new Run(
                new RunProperties(
                    new RunFonts { Ascii = "Times New Roman", ComplexScript = "Times New Roman", EastAsia = "Times New Roman", HighAnsi = "Times New Roman" },
                    new FontSize { Val = new StringValue("22") }
                ),
                new Text("ЭСҚ: Оң; Жүйе: Open Almaty")
            );
            footerPartOdd.Footer = new Footer(new Paragraph(
                new ParagraphProperties(new Justification() { Val = JustificationValues.Center }),
                runOddFooter));

            var runEvenFooter = new Run(
                new RunProperties(
                    new RunFonts { Ascii = "Times New Roman", ComplexScript = "Times New Roman", EastAsia = "Times New Roman", HighAnsi = "Times New Roman" },
                    new FontSize { Val = new StringValue("22") }
                ),
                new Text("ЭЦП: Положительна; Система: Open Almaty")
            );
            footerPartEven.Footer = new Footer(new Paragraph(
                new ParagraphProperties(new Justification() { Val = JustificationValues.Center }),
                runEvenFooter));

            //Replace header references
            var sections = mainDocumentPart.Document.Body.Elements<SectionProperties>();
            foreach(var section in sections) {
                // Delete existing references to headers and footers
                section.RemoveAllChildren<HeaderReference>();
                section.RemoveAllChildren<FooterReference>();
                // Create the new headers
                section.PrependChild(new HeaderReference() { Id = headerPartIdOdd, Type = HeaderFooterValues.Default });
                section.PrependChild(new HeaderReference() { Id = headerPartIdEven, Type = HeaderFooterValues.Even });
                // Create the new footers
                section.PrependChild(new FooterReference() { Id = footerPartIdOdd, Type = HeaderFooterValues.Default });
                section.PrependChild(new FooterReference() { Id = footerPartIdEven, Type = HeaderFooterValues.Even });
            }
        }
    }
}
