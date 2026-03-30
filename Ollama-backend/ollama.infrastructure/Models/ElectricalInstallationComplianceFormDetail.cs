using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ElectricalInstallationComplianceFormDetail
{
    public int ElectricalInstallationComplianceFormDetailsId { get; set; }

    public int? ElectricalInstallationComplianceFormId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? EquipmentUsed { get; set; }

    public string? MaterialUsed { get; set; }

    public string? Manufacturers { get; set; }

    public string? Adequacyandquality { get; set; }

    public string? Adequacyinsize { get; set; }

    public string? Justification { get; set; }

    public string? Date { get; set; }
}
