using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitApplicationDetail
{
    public int PlanningPermitApplicationDetailId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public int? PlanningPermitApplicationStatusId { get; set; }

    public string? Docomments { get; set; }

    public string? Rocomments { get; set; }

    public string? Dodecision { get; set; }

    public string? Rodecision { get; set; }

    public string? ApplicantScheduledDates { get; set; }

    public string? DoapprovedScheduledDate { get; set; }

    public int? SiteInspectionFo { get; set; }

    public int? DistrictId { get; set; }

    public int? PlanningPermitTypeId { get; set; }

    public int? PlanningPermitApplicationFormTypeId { get; set; }

    public int? PlanningPermitBuildingTypeId { get; set; }

    public int? PlanningPermitPropertyTitleTypeId { get; set; }

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

    public bool? FoenteredSiteReportText { get; set; }

    public int? TitleId { get; set; }

    public string? Lirsdecision { get; set; }

    public string? Lirscomments { get; set; }

    public string? SupervisingDirectorDecision { get; set; }

    public string? SupervisingDirectorComments { get; set; }

    public string? GeneralManagerDecision { get; set; }

    public string? GeneralManagerComments { get; set; }

    public string? PermanentSecretaryDecision { get; set; }

    public string? PermanentSecretaryComments { get; set; }

    public string? CommissionerDecision { get; set; }

    public string? CommissionerComments { get; set; }

    public string? GovernorDecision { get; set; }

    public string? GovernorComments { get; set; }

    public virtual ApplicantTitleOwnerClass? ApplicantTitleOwnerClass { get; set; }

    public virtual City? City { get; set; }

    public virtual District? District { get; set; }

    public virtual ICollection<ElectricalVettingFormDetail> ElectricalVettingFormDetails { get; set; } = new List<ElectricalVettingFormDetail>();

    public virtual Lga? Lga { get; set; }

    public virtual PlanningPermitApplication? PlanningPermitApplication { get; set; }

    public virtual ICollection<PlanningPermitApplicationFile> PlanningPermitApplicationFiles { get; set; } = new List<PlanningPermitApplicationFile>();

    public virtual PlanningPermitApplicationFormType? PlanningPermitApplicationFormType { get; set; }

    public virtual PlanningPermitApplicationStatus? PlanningPermitApplicationStatus { get; set; }

    public virtual ICollection<PlanningPermitArchitecturalVettingFormDetail> PlanningPermitArchitecturalVettingFormDetails { get; set; } = new List<PlanningPermitArchitecturalVettingFormDetail>();

    public virtual PlanningPermitBuildingType? PlanningPermitBuildingType { get; set; }

    public virtual ICollection<PlanningPermitDocumentChecklistDetail> PlanningPermitDocumentChecklistDetails { get; set; } = new List<PlanningPermitDocumentChecklistDetail>();

    public virtual ICollection<PlanningPermitEcharting> PlanningPermitEchartings { get; set; } = new List<PlanningPermitEcharting>();

    public virtual PlanningPermitPropertyTitleType? PlanningPermitPropertyTitleType { get; set; }

    public virtual ICollection<PlanningPermitSupportingDocumentDetail> PlanningPermitSupportingDocumentDetails { get; set; } = new List<PlanningPermitSupportingDocumentDetail>();

    public virtual PlanningPermitType? PlanningPermitType { get; set; }

    public virtual ServiceMode? ServiceMode { get; set; }

    public virtual ServiceModeAmount? ServiceModeAmount { get; set; }

    public virtual State? State { get; set; }

    public virtual ICollection<StructuralVettingFormDetail> StructuralVettingFormDetails { get; set; } = new List<StructuralVettingFormDetail>();

    public virtual UserTitle? Title { get; set; }
}
