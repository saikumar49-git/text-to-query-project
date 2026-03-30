using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptExecution
{
    public long ExecutionId { get; set; }

    public int? TenantId { get; set; }

    public int? ReportId { get; set; }

    public int? UserId { get; set; }

    public DateTime? ExecutionDate { get; set; }
}
