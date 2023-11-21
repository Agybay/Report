using Refit;

namespace OpenCity.Report.Application.Dto {
    public class DocumentApiDto {
        public string SourceCode { get; set; }
        public IEnumerable<ByteArrayPart> FormFiles { get; set; }
    }
}
