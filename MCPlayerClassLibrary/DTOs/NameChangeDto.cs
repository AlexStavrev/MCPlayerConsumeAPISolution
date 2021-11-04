using Newtonsoft.Json.Converters;
using System;
using System.Text.Json.Serialization;

namespace MCPlayerApiClient.DTOs
{
    public class NameChangeDto
    {
        public string Name { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ChangedToAt { get; set; }
    }
}
