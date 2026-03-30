using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitApplicationV2
{
    public int PlanningPermitApplicationId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ApplicationNumber { get; set; }

    public int? AgencyId { get; set; }

    public int? RequestServiceId { get; set; }

    public string? PermitNumber { get; set; }

    public DateTime? PermitNumberCreatedOn { get; set; }

    public string? FornaxApplicationNumber { get; set; }

    public string? Status { get; set; }

    public bool? IsBlacklisted { get; set; }

    public DateTime? BlacklistedDateTime { get; set; }

    public bool? IsTaxAdequate { get; set; }

    public bool? IsDemolished { get; set; }

    public string? PropertyLocationDetail { get; set; }

    public virtual ICollection<OwnershipChangeApplication> OwnershipChangeApplications { get; set; } = new List<OwnershipChangeApplication>();

    public virtual ICollection<PlanningPermitLirsdetailsV2> PlanningPermitLirsdetailsV2s { get; set; } = new List<PlanningPermitLirsdetailsV2>();

    public virtual ICollection<UpgradeToFullPermitApplication> UpgradeToFullPermitApplications { get; set; } = new List<UpgradeToFullPermitApplication>();
}
