﻿namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public abstract class DiadocEventContentBase
    {
        public string DiadocBoxId { get; set; }
        public string MessageId { get; set; }
        public string InvoiceId { get; set; }
        public string Torg12Id { get; set; }
        public string InvoiceCorrectionId { get; set; }
        public string UniversalTransferDocumentId { get; set; }
        public string UniversalCorrectionDocumentId { get; set; }
        public string NonformalizedId { get; set; }
        public DiadocUrls DiadocUrls { get; set; }
        public UniversalDocumentFunctionType? UniversalDocumentFunction { get; set; }
    }
}