using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitApplicationDetail
{
    public int RemodelingPermitApplicationDetailId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RemodelingPermitApplicationId { get; set; }

    public int? RemodelingPermitApplicationStatusId { get; set; }

    public string? Docomments { get; set; }

    public string? Rocomments { get; set; }

    public string? Dodecision { get; set; }

    public string? Rodecision { get; set; }

    public string? ApplicantScheduledDates { get; set; }

    public string? DoapprovedScheduledDate { get; set; }

    public int? SiteInspectionFo { get; set; }

    public int? DistrictId { get; set; }

    public int? RemodelingPermitTypeId { get; set; }

    public int? RemodelingPermitApplicationFormTypeId { get; set; }

    public int? RemodelingPermitBuildingTypeId { get; set; }

    public int? RemodelingPermitPropertyTitleTypeId { get; set; }

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

    public string? Status { get; set; }

    public int? DocumentRejectionId { get; set; }

    public bool? IsDemandNoticeIssued { get; set; }

    public string? SupportingDocumentIds { get; set; }

    public virtual ApplicantTitleOwnerClass? ApplicantTitleOwnerClass { get; set; }

    public virtual City? City { get; set; }

    public virtual District? District { get; set; }

    public virtual Lga? Lga { get; set; }

    public virtual ICollection<RemodelingElectricalVettingFormDetail> RemodelingElectricalVettingFormDetails { get; set; } = new List<RemodelingElectricalVettingFormDetail>();

    public virtual RemodelingPermitApplication? RemodelingPermitApplication { get; set; }

    public virtual ICollection<RemodelingPermitDocumentChecklistDetail> RemodelingPermitDocumentChecklistDetails { get; set; } = new List<RemodelingPermitDocumentChecklistDetail>();

    public virtual ICollection<RemodelingStructuralVettingFormDetail> RemodelingStructuralVettingFormDetails { get; set; } = new List<RemodelingStructuralVettingFormDetail>();

    public virtual State? State { get; set; }

    public virtual UserTitle? Title { get; set; }
}
