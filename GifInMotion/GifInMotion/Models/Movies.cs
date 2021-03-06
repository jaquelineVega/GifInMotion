﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace GifInMotion.Models
{
    public partial class Movies
    {
        [JsonProperty("No")]
        public string No { get; set; }
        [JsonProperty("Title")]
        public string Title { get; set; }
        [JsonProperty("Link")]
        public string Link { get; set; }
        [JsonProperty("Episode")]
        public string Episode { get; set; }

    }

    public partial class Movies
    {
        public static Movies[] FromJson(string json) => JsonConvert.DeserializeObject<Movies[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Movies[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

}
