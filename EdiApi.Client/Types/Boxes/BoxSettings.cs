﻿using SkbKontur.EdiApi.Client.Types.Messages;

namespace SkbKontur.EdiApi.Client.Types.Boxes
{
    public abstract class BoxSettings
    {
        public TransportType TransportType { get; set; }
        public bool IsMain { get; set; }
        public DocumentType[] DocumentTypes { get; set; }
        public MessageFormat[] CustomMessageFormats { get; set; }
    }

    public class FtpBoxSettings : BoxSettings
    {
        public FtpBoxSettings()
        {
            TransportType = TransportType.Ftp;
        }

        public string InboxRelativePath { get; set; }
        public string OutboxRelativePath { get; set; }
    }

    public class ProviderBoxSettings : BoxSettings
    {
        public ProviderBoxSettings()
        {
            TransportType = TransportType.Provider;
        }

        public string ProviderTransportBoxId { get; set; }
    }

    public class As2BoxSettings : BoxSettings
    {
        public As2BoxSettings()
        {
            TransportType = TransportType.As2;
        }
    }

    public class WebBoxSettings : BoxSettings
    {
        public WebBoxSettings()
        {
            TransportType = TransportType.Web;
        }
    }

    public class ApiBoxSettings : BoxSettings
    {
        public ApiBoxSettings()
        {
            TransportType = TransportType.Api;
        }

        public bool DeliveryNotificationEnabled { get; set; }
    }

    public class UnknowBoxSettings : BoxSettings
    {
        public UnknowBoxSettings()
        {
            TransportType = TransportType.Unknown;
        }
    }
}