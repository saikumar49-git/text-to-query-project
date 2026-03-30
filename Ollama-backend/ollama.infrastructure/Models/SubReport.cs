using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SubReport
{
    public int SubReportId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ReportName { get; set; }

    public int? CategoryId { get; set; }

    public virtual ReportsCategory? Category { get; set; }

    public virtual ICollection<ReportStoredProcedure> ReportStoredProcedures { get; set; } = new List<ReportStoredProcedure>();
}
