using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class TestTable
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Age { get; set; }

    public string? Email { get; set; }
}
