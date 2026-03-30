using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitCalculation
{
    public int FencingPermitCalculationsId { get; set; }

    public int FencingPermitApplicationId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? LandArea { get; set; }

    public int? TotalAmount { get; set; }

    public int LocationId { get; set; }

    public int LandTypeId { get; set; }

    public int? FencingPermitApplicationFormTypeId { get; set; }

    public virtual FencingPermitApplication FencingPermitApplication { get; set; } = null!;

    public virtual LandType LandType { get; set; } = null!;
}
