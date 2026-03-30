using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Report
{
    public int ReportId { get; set; }

    public string MessageId { get; set; } = null!;

    public string? Status { get; set; }

    public string? SmscId { get; set; }

    public DateTime? ReportDate { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
