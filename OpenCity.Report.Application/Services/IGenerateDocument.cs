using OpenCity.Report.Contracts;

namespace OpenCity.Report.Application.Services {
    public interface IGenerateDocument {
        Task<ResponseDocument> ApplicationCardAsync(CreateDocument dto);
        Task<ResponseDocument> ApplicationPortalCardAsync(CreateDocument dto);
        Task<ResponseDocument> RegistrationNoticeAsync(CreateDocument dto);
        Task<ResponseDocument> Answer(CreateDocument dto);
        Task<ResponseDocument> CoverLetter(CreateDocument dto);
        Task<ResponseDocument> AddQrToCoverLetter(CreateDocument dto);
    }
}
