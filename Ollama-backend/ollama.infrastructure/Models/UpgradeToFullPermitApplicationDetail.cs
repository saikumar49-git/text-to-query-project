using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UpgradeToFullPermitApplicationDetail
{
    public int UtfpapplicationDetailId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? UpgradeToFullPermitApplicationId { get; set; }

    public int? UpgradeToFullPermitApplicationStatusId { get; set; }

    public string? Docomments { get; set; }

    public string? Dodecision { get; set; }

    public int? SiteInspectionFo { get; set; }

    public string? ApplicantScheduledDates { get; set; }

    public string? DoapprovedScheduledDate { get; set; }

    public string? Focomments { get; set; }

    public string? FoenteredSiteReportText { get; set; }

    public int? DistrictId { get; set; }

    public string? Status { get; set; }

    public virtual UpgradeToFullPermitApplication? UpgradeToFullPermitApplication { get; set; }

    public virtual ICollection<UpgradeToFullPermitApplicationFile> UpgradeToFullPermitApplicationFiles { get; set; } = new List<UpgradeToFullPermitApplicationFile>();

    public virtual ICollection<UtfpassessmentFeeCalculation> UtfpassessmentFeeCalculations { get; set; } = new List<UtfpassessmentFeeCalculation>();
}
