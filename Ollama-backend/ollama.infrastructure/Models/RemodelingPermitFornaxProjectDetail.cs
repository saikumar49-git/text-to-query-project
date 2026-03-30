using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitFornaxProjectDetail
{
    public int RemodelingPermitFornaxDetailsId { get; set; }

    public int? RemodelingPermitApplicationId { get; set; }

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

    public virtual RemodelingPermitApplication? RemodelingPermitApplication { get; set; }
}
