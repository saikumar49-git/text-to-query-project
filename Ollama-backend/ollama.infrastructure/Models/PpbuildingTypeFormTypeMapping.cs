using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PpbuildingTypeFormTypeMapping
{
    public int PpmappingId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int BuildingTypeId { get; set; }

    public int FormTypeId { get; set; }

    public virtual PlanningPermitBuildingType BuildingType { get; set; } = null!;

    public virtual PlanningPermitApplicationFormType FormType { get; set; } = null!;
}
