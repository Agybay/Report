using DocumentFormat.OpenXml.Wordprocessing;
namespace OpenCity.Report.Application.Services {
    public interface ICoverLetterFormatter {
        void Execute(Document documentx);
    }
    public interface ICoverLetterFormatter<T> : ICoverLetterFormatter {
        T Parameter { get; set; }
    }
}
