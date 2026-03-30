using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UseType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
