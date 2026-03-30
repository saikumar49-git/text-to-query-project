using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitApplicationDetail
{
    public int RenovationPermitApplicationDetailId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RenovationPermitApplicationId { get; set; }

    public int? RenovationPermitApplicationStatusId { get; set; }

    public string? Docomments { get; set; }

    public string? Rocomments { get; set; }

    public string? Dodecision { get; set; }

    public string? Rodecision { get; set; }

    public string? ApplicantScheduledDates { get; set; }

    public string? DoapprovedScheduledDate { get; set; }

    public int? SiteInspectionFo { get; set; }

    public int? DistrictId { get; set; }

    public int? RenovationPermitTypeId { get; set; }

    public int? RenovationPermitApplicationFormTypeId { get; set; }

    public int? RenovationPermitBuildingTypeId { get; set; }

    public int? RenovationPermitPropertyTitleTypeId { get; set; }

    public int? ApplicantTitleOwnerClassId { get; set; }

    public int? StateId { get; set; }

    public int? ServiceModeId { get; set; }

    public int? ServiceModeAmountId { get; set; }

    public string? TitleOwnerCorporateName { get; set; }

    public string? TitleOwnerFirstName { get; set; }

    public string? TitleOwnerLastName { get; set; }

    public string? ArchitectEngineerDecision { get; set; }

    public string? ArchitectEngineerComments { get; set; }

    public string? TitleOwnerMiddleName { get; set; }

    public int? LgaId { get; set; }

    public int? CityId { get; set; }

    public int? PpfullOrProvisionalPermitTypeId { get; set; }

    public string? Focomments { get; set; }

    public string? FoenteredSiteReportText { get; set; }

    public int? TitleId { get; set; }

    public virtual ApplicantTitleOwnerClass? ApplicantTitleOwnerClass { get; set; }

    public virtual City? City { get; set; }

    public virtual District? District { get; set; }

    public virtual Lga? Lga { get; set; }

    public virtual RenovationPermitApplication? RenovationPermitApplication { get; set; }

    public virtual PlanningPermitApplicationFormType? RenovationPermitApplicationFormType { get; set; }

    public virtual RenovationPermitApplicationStatus? RenovationPermitApplicationStatus { get; set; }

    public virtual PlanningPermitBuildingType? RenovationPermitBuildingType { get; set; }

    public virtual PlanningPermitPropertyTitleType? RenovationPermitPropertyTitleType { get; set; }

    public virtual PlanningPermitType? RenovationPermitType { get; set; }

    public virtual ServiceMode? ServiceMode { get; set; }

    public virtual ServiceModeAmount? ServiceModeAmount { get; set; }

    public virtual State? State { get; set; }

    public virtual UserTitle? Title { get; set; }
}
