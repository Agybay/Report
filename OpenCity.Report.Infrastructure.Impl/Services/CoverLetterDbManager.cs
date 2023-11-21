using DocumentFormat.OpenXml.Packaging;
using OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter;
using OpenCity.Report.Application.Services;
using OpenCity.Report.Contracts;

namespace OpenCity.Report.Infrastructure.Impl.Services {
    /// <summary>
    /// Сопроводительное письмо менеджер базы данных
    /// </summary>
    public class CoverLetterDbManager : IDocumentAction {

        public CoverLetterDbManager() {
        }

        byte[] IDocumentAction.CreateDocument(CoverLetterDto model) {
            var mapPath = string.Empty;
            switch(model.ApplicantTypeCode) {
                case "LegalPerson":
                    mapPath = Path.Combine("wwwroot", "CoverLetterLegal.docx");
                    break;
                case "IndividualPerson":
                    mapPath = Path.Combine("wwwroot", "CoverLetterPhysical.docx");
                    break;
            }
            var signedBy = "";
            var byteArray = System.IO.File.ReadAllBytes(mapPath);
            using(var mem = new MemoryStream()) {
                mem.Write(byteArray, 0, byteArray.Length);
                using(var wordDoc =
                    WordprocessingDocument.Open(mem, true)) {
                    var documentx = wordDoc.MainDocumentPart.Document;
                    Execute(documentx,
                        new ExecutorOrganizationFormatter(model.ExecutorOrganization),
                        new DocumentNumberFormatter(model.ApplicationNumber),
                        new FullNameFormatter(model.ApplicantTypeCode == "IndividualPerson" ?
                        model.ApplicantFullName : model.ApplicantOrganizationName),
                        new NumberFormatter(model.ApplicationNumber),
                        new ExecutorsPhoneFormatter(new[] { model.ExecutorTelephoneNumber }),
                        new ExecutorFormatter(model.ExecutorFullName),
                        new EmployeeFullnameFormatter(signedBy),
                        new DateSignedFormmater(DateTime.Now.ToString("dd.MM.yyyy"))
                        );
                    wordDoc.MainDocumentPart.Document.Save();
                }
                return mem.ToArray();
            }
        }



        public byte[] UpdateWithSignature(AddQrCodeToCoverLetterDto model) {
            using(var mem = new MemoryStream()) {
                mem.Write(model.DocumentContent, 0, model.DocumentContent.Length);
                using(var wordDoc =
                    WordprocessingDocument.Open(mem, true)) {
                    var documentx = wordDoc.MainDocumentPart.Document;
                    Execute(documentx,
                        new SignedHeaderFooterFormatter(true, model.SignatoryFullName, DateTime.Now),
                        new ImageFormatter(
                            true,
                            $"Регистрационный номер обращения:{model.ApplicationNumber}." +
                            $"Дата подписания:{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}." +
                            $"ФИО сотрудника (подписавшего):{model.SignatoryFullName}."));
                    wordDoc.MainDocumentPart.Document.Save();
                }
                return mem.ToArray();
            }
        }

        private void Execute(DocumentFormat.OpenXml.Wordprocessing.Document doc, params ICoverLetterFormatter[] formatters) {
            foreach(var formatter in formatters) {
                formatter.Execute(doc);
            }
        }
    }
}
