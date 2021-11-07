using System;
using System.Collections.Generic;

namespace MCPlayerApiClient.DTOs
{
    public class PlayerDto
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public IEnumerable<NameChangeDto> Names { get; set; }
    }
}
