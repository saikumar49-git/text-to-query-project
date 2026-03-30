using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MstReportDefault
{
    public int Id { get; set; }

    public string? DefaultValue { get; set; }

    public bool? Active { get; set; }
}
