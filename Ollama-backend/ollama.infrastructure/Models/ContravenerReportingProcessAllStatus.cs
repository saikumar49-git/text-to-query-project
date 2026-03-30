using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ContravenerReportingProcessAllStatus
{
    public int ContravenerReportingProcessAllStatusId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? StatusNumber { get; set; }

    public string? StatusName { get; set; }

    public string? StatusMessage { get; set; }
}
