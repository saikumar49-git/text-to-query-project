using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ReportStoredProcedure
{
    public int ReportStoredProcedureId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? StoredProcedureName { get; set; }

    public int? SubReportId { get; set; }

    public virtual SubReport? SubReport { get; set; }
}
