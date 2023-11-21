using Refit;

namespace OpenCity.Report.Application.Services {
    public interface IFileStorageService {
        [Multipart]
        [Post("/api/v2/Attachments")]
        Task<List<Guid>> SaveFile(string SourceCode, IEnumerable<ByteArrayPart> FormFiles);
    }
}
