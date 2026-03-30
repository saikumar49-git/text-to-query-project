using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitVitalFormDetailsV2
{
    public int PpvitalFormDetailsId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public int? ProposedDevelopmentId { get; set; }

    public string? BuildingTypeId { get; set; }

    public int? ApplicantTitleOwnerClassId { get; set; }

    public string? TitleOwnerCorporateName { get; set; }

    public string? TitleOwnerFirstName { get; set; }

    public string? TitleOwnerLastName { get; set; }

    public string? TitleOwnerMiddleName { get; set; }

    public int? TitleId { get; set; }

    public string? ApplicantFirstName { get; set; }

    public string? ApplicantMiddleName { get; set; }

    public string? ApplicantLastName { get; set; }

    public string? ApplicantAddress { get; set; }

    public string? ApplicantTelephoneNumber { get; set; }

    public string? ApplicantEmailAddress { get; set; }

    public int? StateId { get; set; }

    public int? LgaId { get; set; }

    public int? CityId { get; set; }

    public int? DistrictId { get; set; }

    public int? ServiceModeId { get; set; }

    public int? ServiceModeAmountId { get; set; }

    public string? ArchitectData { get; set; }

    public string? StructuralData { get; set; }

    public string? MechanicalData { get; set; }

    public string? ElectricalData { get; set; }

    public string? DetailsOfSubjectSite { get; set; }

    public string? TitleDocument { get; set; }

    public string? PublicUtilities { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? PlanningPermitTypeId { get; set; }

    public string? OtherBuildingType { get; set; }
}
