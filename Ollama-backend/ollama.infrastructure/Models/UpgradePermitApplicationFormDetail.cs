using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UpgradePermitApplicationFormDetail
{
    public int UpgradePermitApplicationFormDetailId { get; set; }

    public int? UpgradeToFullPermitApplicationId { get; set; }

    public string? ApplicantInformation { get; set; }

    public string? CompanyInformation { get; set; }

    public string? ProjectInformation { get; set; }

    public string? UpdatedProjectDetailsInformation { get; set; }

    public string? ContractorEngineerInformation { get; set; }

    public bool? Declaration { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
