using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FinishesComplianceFormTestResult
{
    public int FcftestId { get; set; }

    public string? EarthResistanceTest { get; set; }

    public string? InsulationResistanceTest { get; set; }

    public string? ContinuityTest { get; set; }

    public string? PolarityTest { get; set; }

    public int? FinishesComplianceFormId { get; set; }

    public int? FinishesComplianceFormCategoryId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
