using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptReport
{
    public int ReportId { get; set; }

    public int? CategoryId { get; set; }

    public string? ReportName { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public string? Spname { get; set; }

    public string? PermissionAttr { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }

    public int? DeletedBy { get; set; }
}
