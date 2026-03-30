using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitCalculation
{
    public int RemodelingPermitCalculationsId { get; set; }

    public int RemodelingPermitApplicationId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? LandArea { get; set; }

    public int? TotalAmount { get; set; }

    public int LocationId { get; set; }

    public int LandTypeId { get; set; }

    public int? NumberOfFloors { get; set; }

    public string? FloorsData { get; set; }

    public bool? IsActive { get; set; }

    public virtual LandType LandType { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual RemodelingPermitApplication RemodelingPermitApplication { get; set; } = null!;
}
