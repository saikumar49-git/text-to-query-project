using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FinishesComplianceForm
{
    public int FinishesComplianceFormId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ProjectTitle { get; set; }

    public string? OwnerName { get; set; }

    public string? OwnerAddress { get; set; }

    public string? MainContractorName { get; set; }

    public string? SiteLocation { get; set; }

    public DateTime? CommencementDate { get; set; }

    public string? FormNumber { get; set; }

    public string? OwnerFirstName { get; set; }

    public string? OwnerMiddleName { get; set; }

    public string? OwnerLastName { get; set; }

    public string? MainContractorFirstName { get; set; }

    public string? MainContractorMiddleName { get; set; }

    public string? MainContractorLastName { get; set; }

    public string? Address { get; set; }

    public int? StateId { get; set; }

    public int? Lgaid { get; set; }

    public int? CityId { get; set; }

    public int? StageCertificationApplicationId { get; set; }

    public string? FormName { get; set; }

    public string? GeneralRemark { get; set; }
}
