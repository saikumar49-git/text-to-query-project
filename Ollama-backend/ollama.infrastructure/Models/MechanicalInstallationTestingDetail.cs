using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MechanicalInstallationTestingDetail
{
    public int MicftdetailsId { get; set; }

    public string? MethodsUsed { get; set; }

    public string? AdequacyEffectiveness { get; set; }

    public DateTime? TestingDate { get; set; }

    public string? Justification { get; set; }

    public int? MicformId { get; set; }

    public int? MifcategoryId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
