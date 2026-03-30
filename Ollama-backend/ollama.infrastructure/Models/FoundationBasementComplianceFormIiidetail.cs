using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FoundationBasementComplianceFormIiidetail
{
    public int FbcformCategoryDetailsId { get; set; }

    public int? FbcomplianceFormId { get; set; }

    public int? FbcformCategoryId { get; set; }

    public string? BuildingType { get; set; }

    public string? Reinforcement { get; set; }

    public string? FoundationWalls { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Signature { get; set; }
}
