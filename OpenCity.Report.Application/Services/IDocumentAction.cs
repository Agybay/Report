using OpenCity.Report.Contracts;

namespace OpenCity.Report.Application.Services {
    public interface IDocumentAction {
        byte[] CreateDocument(CoverLetterDto model);
        byte[] UpdateWithSignature(AddQrCodeToCoverLetterDto model);
    }
}
