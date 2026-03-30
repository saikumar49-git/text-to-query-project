using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ElectricalInstallationComplianceFormCategory
{
    public int ElectricalInstallationComplianceFormCategoryId { get; set; }

    public int? ElectricalInstallationComplianceFormId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? NameOfEngineer { get; set; }

    public string? Signature { get; set; }

    public string? DateOfSubmission { get; set; }

    public string? Reinforcement { get; set; }
}
