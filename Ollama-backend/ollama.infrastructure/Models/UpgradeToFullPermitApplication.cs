using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UpgradeToFullPermitApplication
{
    public int UpgradeToFullPermitApplicationId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ApplicationNumber { get; set; }

    public int AgencyId { get; set; }

    public int RequestServiceId { get; set; }

    public string? PermitNumber { get; set; }

    public DateTime? PermitNumberCreatedOn { get; set; }

    public string? Status { get; set; }

    public bool? IsPermitApplicationValid { get; set; }

    public bool? IsPermitNumberVerified { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public bool IsSiteInspectionRequired { get; set; }

    public string? PlanningPermitNumber { get; set; }

    public string? PropertyLocationDetail { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual PlanningPermitApplicationV2? PlanningPermitApplication { get; set; }

    public virtual RequestService RequestService { get; set; } = null!;

    public virtual ICollection<UpgradeToFullPermitApplicationDetail> UpgradeToFullPermitApplicationDetails { get; set; } = new List<UpgradeToFullPermitApplicationDetail>();

    public virtual ICollection<UpgradeToFullPermitPayment> UpgradeToFullPermitPayments { get; set; } = new List<UpgradeToFullPermitPayment>();
}
