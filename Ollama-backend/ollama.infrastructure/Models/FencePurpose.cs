using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencePurpose
{
    public int FencePurposeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? FencePurposeCode { get; set; }

    public string? FencePurposeName { get; set; }

    public virtual ICollection<FencingSiteInspectionReport> FencingSiteInspectionReports { get; set; } = new List<FencingSiteInspectionReport>();
}
