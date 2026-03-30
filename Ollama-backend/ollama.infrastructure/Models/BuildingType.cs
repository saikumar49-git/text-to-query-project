using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class BuildingType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
