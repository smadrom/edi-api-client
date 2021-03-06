﻿using System;

using Newtonsoft.Json.Linq;

using SkbKontur.EdiApi.Client.Types.Boxes;

namespace SkbKontur.EdiApi.Client.Types.Serialization
{
    public class JsonBoxSettingsConvertor : JsonCreationConverter<BoxSettings>
    {
        protected override BoxSettings Create(Type objectType, JObject jObject)
        {
            var type = jObject["TransportType"] != null ? jObject["TransportType"].Value<string>() : null;
            TransportType transportType;
            if (Enum.TryParse(type, out transportType))
            {
                if (transportType == TransportType.Api)
                    return new ApiBoxSettings();
                if (transportType == TransportType.As2)
                    return new As2BoxSettings();
                if (transportType == TransportType.Ftp)
                    return new FtpBoxSettings();
                if (transportType == TransportType.Provider)
                    return new ProviderBoxSettings();
                if (transportType == TransportType.Web)
                    return new WebBoxSettings();
            }
            return null;
        }
    }
}