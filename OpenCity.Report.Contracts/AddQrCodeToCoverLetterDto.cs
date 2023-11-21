namespace OpenCity.Report.Contracts {
    public class AddQrCodeToCoverLetterDto {
        public string ApplicationNumber { get; set; }
        public string SignatoryFullName { get; set; }
        public byte[] DocumentContent { get; set; }
    }
}
