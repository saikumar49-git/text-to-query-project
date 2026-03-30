using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RequestService
{
    public int RequestServiceId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? AgencyId { get; set; }

    public string? RequestServiceName { get; set; }

    public string? RequestServiceDescription { get; set; }

    public string? ServiceAbbreviation { get; set; }

    public int? Ranking { get; set; }

    public bool? IsEmailNotification { get; set; }

    public string? RequestServiceVideoLink { get; set; }

    public string? RequestServiceProcedure { get; set; }

    public string? RequestServiceVideoThumbnail { get; set; }

    public string? RequestServiceIcon { get; set; }

    public decimal? ProcessingFeePercentValue { get; set; }

    public decimal? PreScreeningAmount { get; set; }

    public int? Months { get; set; }

    public int? Discount { get; set; }

    public bool? DiscountOption { get; set; }

    public virtual Agency? Agency { get; set; }

    public virtual ICollection<CertifiedTrueCopyApplicationStatus> CertifiedTrueCopyApplicationStatuses { get; set; } = new List<CertifiedTrueCopyApplicationStatus>();

    public virtual ICollection<DemolitionPermitApplication> DemolitionPermitApplications { get; set; } = new List<DemolitionPermitApplication>();

    public virtual ICollection<FencingPermitApplicationStatus> FencingPermitApplicationStatuses { get; set; } = new List<FencingPermitApplicationStatus>();

    public virtual ICollection<FencingPermitApplication> FencingPermitApplications { get; set; } = new List<FencingPermitApplication>();

    public virtual ICollection<LasbcademolitionApplicationBySelf> LasbcademolitionApplicationBySelves { get; set; } = new List<LasbcademolitionApplicationBySelf>();

    public virtual ICollection<OtherServiceCharge> OtherServiceCharges { get; set; } = new List<OtherServiceCharge>();

    public virtual ICollection<OwnershipChangeApplicationStatus> OwnershipChangeApplicationStatuses { get; set; } = new List<OwnershipChangeApplicationStatus>();

    public virtual ICollection<OwnershipChangeApplication> OwnershipChangeApplications { get; set; } = new List<OwnershipChangeApplication>();

    public virtual ICollection<PlanningPermitApplicationStatus> PlanningPermitApplicationStatuses { get; set; } = new List<PlanningPermitApplicationStatus>();

    public virtual ICollection<PlanningPermitApplication> PlanningPermitApplications { get; set; } = new List<PlanningPermitApplication>();

    public virtual ICollection<RemodelingPermitApplicationStatus> RemodelingPermitApplicationStatuses { get; set; } = new List<RemodelingPermitApplicationStatus>();

    public virtual ICollection<RemodelingPermitApplication> RemodelingPermitApplications { get; set; } = new List<RemodelingPermitApplication>();

    public virtual ICollection<RenovationPermitApplicationStatus> RenovationPermitApplicationStatuses { get; set; } = new List<RenovationPermitApplicationStatus>();

    public virtual ICollection<RenovationPermitApplication> RenovationPermitApplications { get; set; } = new List<RenovationPermitApplication>();

    public virtual ICollection<RestampingPlanningApplication> RestampingPlanningApplications { get; set; } = new List<RestampingPlanningApplication>();

    public virtual ICollection<RevalidationPermitApplication> RevalidationPermitApplications { get; set; } = new List<RevalidationPermitApplication>();

    public virtual ICollection<Rmdapplication> Rmdapplications { get; set; } = new List<Rmdapplication>();

    public virtual ICollection<ServiceModeAmount> ServiceModeAmounts { get; set; } = new List<ServiceModeAmount>();

    public virtual ICollection<StageCertificationApplicationStatus> StageCertificationApplicationStatuses { get; set; } = new List<StageCertificationApplicationStatus>();

    public virtual ICollection<StageCertificationApplication> StageCertificationApplications { get; set; } = new List<StageCertificationApplication>();

    public virtual ICollection<UpgradeToFullPermitApplicationStatus> UpgradeToFullPermitApplicationStatuses { get; set; } = new List<UpgradeToFullPermitApplicationStatus>();

    public virtual ICollection<UpgradeToFullPermitApplication> UpgradeToFullPermitApplications { get; set; } = new List<UpgradeToFullPermitApplication>();
}
