using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PpfullOrProvisionalPermitType
{
    public int PpfullOrProvisionalPermitTypeId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? PermitType { get; set; }

    public int PlanningPermitPropertyTitleTypeId { get; set; }

    public virtual PlanningPermitPropertyTitleType PlanningPermitPropertyTitleType { get; set; } = null!;
}
