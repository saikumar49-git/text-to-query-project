using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ServiceMode
{
    public int ServiceModeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ServiceModeName { get; set; }

    public string? ServiceModeDescription { get; set; }

    public virtual ICollection<PlanningPermitApplicationDetail> PlanningPermitApplicationDetails { get; set; } = new List<PlanningPermitApplicationDetail>();

    public virtual ICollection<RenovationPermitApplicationDetail> RenovationPermitApplicationDetails { get; set; } = new List<RenovationPermitApplicationDetail>();

    public virtual ICollection<ServiceModeAmount> ServiceModeAmounts { get; set; } = new List<ServiceModeAmount>();
}
