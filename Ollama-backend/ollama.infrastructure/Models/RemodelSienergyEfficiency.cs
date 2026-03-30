using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelSienergyEfficiency
{
    public int RemodelSienergyEfficiencyId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string EnergyEfficiency { get; set; } = null!;
}
