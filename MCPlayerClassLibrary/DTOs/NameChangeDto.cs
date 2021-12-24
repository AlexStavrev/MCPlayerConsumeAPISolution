using Newtonsoft.Json.Converters;
using System;
using System.Text.Json.Serialization;

namespace MCPlayerApiClient.DTOs
{
    public sealed class NameChangeDto
    {
        public string Name { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ChangedToAt { get; set; }

        public override string ToString()
        {
            string at = (ChangedToAt.Date > DateTime.MinValue) ? $"[{ChangedToAt:dd/MM/yyyy HH:mm}] " : "";
            return $"{at}{Name}";
        }
    }
}
