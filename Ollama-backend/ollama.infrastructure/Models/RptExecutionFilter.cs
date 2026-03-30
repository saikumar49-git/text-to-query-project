using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptExecutionFilter
{
    public long Id { get; set; }

    public long? ExecutionId { get; set; }

    public int? FilterId { get; set; }

    public string? ParamValue { get; set; }
}
