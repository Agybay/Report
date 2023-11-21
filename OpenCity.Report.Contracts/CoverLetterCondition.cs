namespace OpenCity.Report.Contracts {
    public enum CoverLetterCondition {
        /// <summary>
        /// Доступен для редактирования
        /// </summary>
        ControlMemberStete = 1,
        /// <summary>
        /// Отправлен на подпись
        /// </summary>
        SentForSignature = 2,
        /// <summary>
        /// Обработан
        /// </summary>
        CompletedState = 3,
        /// <summary>
        /// Отправлен на подпись виде Word формате
        /// </summary>
        SentForSignatureFormDocx = 4
    }
}
