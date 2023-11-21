using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OpenCity.Report.Application.Dto;
using OpenCity.Report.Application.Services;
using OpenCity.Report.Contracts;
using OpenCity.Report.Infrastructure.Impl.Models;
using Refit;

namespace OpenCity.Report.Infrastructure.Impl.Services {
    public class GenerateDocument : IGenerateDocument {
        private readonly IFileStorageService _storageService;
        private readonly ReportByteDataExtractor _reportByteDataExtractor;
        private readonly ILogger<GenerateDocument> _logger;

        public GenerateDocument(IFileStorageService storageService,
            ReportByteDataExtractor reportByteDataExtractor,
            ILogger<GenerateDocument> logger) {

            _storageService = storageService;
            _reportByteDataExtractor = reportByteDataExtractor;
            _logger = logger;
        }

        public async Task<ResponseDocument> AddQrToCoverLetter(CreateDocument dto) {
            throw new NotImplementedException();
        }


        public async Task<ResponseDocument> Answer(CreateDocument dto) {
            var content = Deserialize<AnswerDto>(dto.Content);
            var model = new AnswerModel {
                AnswerText = content.AnswerText,
                ApplicationNumber = content.ApplicationNumber
            };

            var document = await _reportByteDataExtractor.Get(model);
            var documentId = await SaveDocument(document.Value, "File.pdf", DocumentMimeType.Pdf);

            return new ResponseDocument {
                ApplicationId = dto.ApplicationId,
                CorrelationId = dto.CorrelationId,
                DocumentId = documentId,
                MimeType = DocumentMimeType.Pdf,
                ReportType = dto.ReportType
            };
        }

        public async Task<ResponseDocument> ApplicationCardAsync(CreateDocument dto) {
            var content = Deserialize<ApplicationCardDto>(dto.Content);
            var model = new ApplicationCardModel {
              AddressKk = content.AddressKk,
              AddressRu = content.AddressRu,
              ApplicationTypeRu = content.ApplicationTypeRu,
              ApplicantNameOrOrganizaionName = content.ApplicantNameOrOrganizaionName,
              ApplicationSourceCode = content.ApplicationSourceCode,
              ApplicationText = content.ApplicationText,
              ApplicationTypeKk = content.ApplicationTypeKk,
              Date = content.Date,
              TelephonNumber = content.TelephonNumber,
              Xin = content.Xin
            };

            var document = await _reportByteDataExtractor.Get(model);
            var documentId = await SaveDocument(document.Value, "ApplicationCard.pdf", DocumentMimeType.Pdf);

            return new ResponseDocument {
                ApplicationId = dto.ApplicationId,
                CorrelationId = dto.CorrelationId,
                DocumentId = documentId,
                MimeType = DocumentMimeType.Pdf,
                ReportType = dto.ReportType
            };
        }

        public async Task<ResponseDocument> ApplicationPortalCardAsync(CreateDocument dto) {
            throw new NotImplementedException();
        }

        public async Task<ResponseDocument> CoverLetter(CreateDocument dto) {
            throw new NotImplementedException();
        }

        public async Task<ResponseDocument> RegistrationNoticeAsync(CreateDocument dto) {
            throw new NotImplementedException();
        }

        private async Task<Guid> SaveDocument(byte[] content, string fileName, string mimeTypes) {
            var dto = new DocumentApiDto {
                SourceCode = "Applications",
                FormFiles = new[]
                {
                    new ByteArrayPart(content, fileName,mimeTypes)
                }
            };
            var documentId = await _storageService.SaveFile(dto.SourceCode, dto.FormFiles);

            return documentId.SingleOrDefault();
        }

        private T Deserialize<T>(string data) where T : class {
            try {
                var content = JsonConvert.DeserializeObject<T>(data,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
               
                if(content is null) {
                    throw new Exception("Content null");
                    _logger.Log(LogLevel.Error, "Content Null ");
                }

                return (T)content;
            }
            catch(Exception ex) {
                throw new Exception(ex.Message);
                _logger.Log(LogLevel.Error, ex.Message);
            }
        }
    }
}
