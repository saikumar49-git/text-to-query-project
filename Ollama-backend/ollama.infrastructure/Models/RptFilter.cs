using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptFilter
{
    public int FilterId { get; set; }

    public string? FilterName { get; set; }

    public string? ControlType { get; set; }

    public string? SourceType { get; set; }

    public string? SourceQuery { get; set; }

    public string? SourceValues { get; set; }

    public string? SpparamName { get; set; }
}
