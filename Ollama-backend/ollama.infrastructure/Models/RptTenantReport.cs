using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptTenantReport
{
    public int TenantId { get; set; }

    public int? ReportId { get; set; }

    public bool? CanView { get; set; }
}
