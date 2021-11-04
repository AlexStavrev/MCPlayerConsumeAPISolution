using System;
using System.Collections.Generic;

namespace MCPlayerApiClient.DTOs
{
    public class Player
    {
        public string Name { get; set; }
        public Guid UUID { get; set; }
        public IEnumerable<string> Names { get; set; }
    }
}
