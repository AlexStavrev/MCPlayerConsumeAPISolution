using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MCPlayerApiClient.DTOs
{
    public class PlayerDto
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public IEnumerable<NameChangeDto> Names { get; set; }
    }
}
