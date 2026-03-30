using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PalnningPermitFornaxProjectDetail
{
    public int PalnningPermitFornaxDetailsId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public string ProjectId { get; set; } = null!;

    public string? FileName { get; set; }

    public string? FileDescription { get; set; }

    public bool? Status { get; set; }

    public string? Error { get; set; }

    public string? ProjectName { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModiFiedOn { get; set; }

    public virtual PlanningPermitApplication? PlanningPermitApplication { get; set; }
}
