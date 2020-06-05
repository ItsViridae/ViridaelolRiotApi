using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using ViridaeRiotApi.Data.Constants;

namespace ViridaeRiotApi.Helpers
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                PlatformIdConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
    internal class PlatformIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PlatformId) || t == typeof(PlatformId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "NA":
                    return PlatformId.Na;
                case "NA1":
                    return PlatformId.Na1;
                case "na1":
                    return PlatformId.PlatformIdNa1;
            }
            throw new Exception("Cannot unmarshal type PlatformId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PlatformId)untypedValue;
            switch (value)
            {
                case PlatformId.Na:
                    serializer.Serialize(writer, "NA");
                    return;
                case PlatformId.Na1:
                    serializer.Serialize(writer, "NA1");
                    return;
                case PlatformId.PlatformIdNa1:
                    serializer.Serialize(writer, "na1");
                    return;
            }
            throw new Exception("Cannot marshal type PlatformId");
        }

        public static readonly PlatformIdConverter Singleton = new PlatformIdConverter();
    }
}
