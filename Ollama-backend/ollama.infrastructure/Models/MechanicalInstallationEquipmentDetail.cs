using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MechanicalInstallationEquipmentDetail
{
    public int MicfedetailsId { get; set; }

    public string? EquipmentsUsed { get; set; }

    public string? Manufacturers { get; set; }

    public string? AdequacyQuality { get; set; }

    public string? Justification { get; set; }

    public int? MicformId { get; set; }

    public int? MifcategoryId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
