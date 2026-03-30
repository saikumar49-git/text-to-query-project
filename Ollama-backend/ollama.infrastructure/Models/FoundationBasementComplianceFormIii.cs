using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FoundationBasementComplianceFormIii
{
    public int FbcomplianceFormId { get; set; }

    public string? ProjectTitle { get; set; }

    public string? SiteLocation { get; set; }

    public string? OwnerFirstName { get; set; }

    public string? OwnerMiddleName { get; set; }

    public string? OwnerLastName { get; set; }

    public string? Address { get; set; }

    public int? CityId { get; set; }

    public int? Lgaid { get; set; }

    public int? StateId { get; set; }

    public int? StageCerificationApplicationId { get; set; }

    public string? MainContractorFirstName { get; set; }

    public string? MainContractorMiddleName { get; set; }

    public string? MainContractorLastName { get; set; }

    public string? MechSubContractorFirstName { get; set; }

    public string? MechSubContractorMiddleName { get; set; }

    public string? MechSubContractorLastName { get; set; }

    public string? ElectSubContractorFirstName { get; set; }

    public string? ElectSubContractorMiddleName { get; set; }

    public string? ElectSubContractorLastName { get; set; }

    public string? OtherSubContractorFirstName { get; set; }

    public string? OtherSubContractorMiddleName { get; set; }

    public string? OtherSubContractorLastName { get; set; }

    public DateTime? CommencementDate { get; set; }

    public string? TestingHouse { get; set; }

    public string? GeneralRemarks { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
