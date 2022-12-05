using System;
using System.Collections.Generic;

namespace MCPlayerApiClient.DTOs;

public sealed class PlayerDto
{
    public string Name { get; set; }
    public Guid Id { get; set; }
    public IEnumerable<NameChangeDto> Names { get; set; }
}
