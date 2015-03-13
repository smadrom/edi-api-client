﻿namespace KonturEdi.Api.Types.Messages.BoxEventsContents
{
    public class MessageDiadocEventContent : MessageOutboxEventContent
    {
        public string DiadocBoxId { get; set; }
        public string InvoiceId { get; set; }
        public string MessageId { get; set; }
        public string Torg12Id { get; set; }
        public DiadocUrls DiadocUrls { get; set; }
    }
}