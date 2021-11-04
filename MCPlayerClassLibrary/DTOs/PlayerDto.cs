using System.Collections.Generic;

namespace MCPlayerApiClient.DTOs
{
    public class PlayerDto
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public IEnumerable<NameChangeDto> Names { get; set; }
    }
}
