using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptShare
{
    public int Id { get; set; }

    public long ExecutionId { get; set; }

    public int SharedBy { get; set; }

    public string SharedTo { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime SharedOn { get; set; }
}
