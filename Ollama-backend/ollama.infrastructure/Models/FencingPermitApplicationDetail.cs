using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitApplicationDetail
{
    public int FencingPermitApplicationDetailId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? FencingPermitApplicationId { get; set; }

    public int? FencingPermitApplicationStatusId { get; set; }

    public string? Docomments { get; set; }

    public string? Rocomments { get; set; }

    public string? Dodecision { get; set; }

    public string? Rodecision { get; set; }

    public string? ApplicantScheduledDates { get; set; }

    public string? DoapprovedScheduledDate { get; set; }

    public int? SiteInspectionFo { get; set; }

    public int? DistrictId { get; set; }

    public int? FencingPermitPropertyTitleTypeId { get; set; }

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

    public int? DocumentRejectionId { get; set; }

    public string? SupportingDocumentIds { get; set; }

    public bool? IsDemandNoticeIssued { get; set; }

    public virtual ApplicantTitleOwnerClass? ApplicantTitleOwnerClass { get; set; }

    public virtual City? City { get; set; }

    public virtual District? District { get; set; }

    public virtual FencingPermitApplication? FencingPermitApplication { get; set; }

    public virtual ICollection<FencingPermitApplicationFile> FencingPermitApplicationFiles { get; set; } = new List<FencingPermitApplicationFile>();

    public virtual FencingPermitApplicationStatus? FencingPermitApplicationStatus { get; set; }

    public virtual ICollection<FencingPermitEcharting> FencingPermitEchartings { get; set; } = new List<FencingPermitEcharting>();

    public virtual ICollection<FencingStructuralVettingFormDetail> FencingStructuralVettingFormDetails { get; set; } = new List<FencingStructuralVettingFormDetail>();

    public virtual Lga? Lga { get; set; }

    public virtual State? State { get; set; }
}
