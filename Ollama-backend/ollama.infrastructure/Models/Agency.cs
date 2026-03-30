using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Agency
{
    public int AgencyId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? AgencyName { get; set; }

    public string? AgencyDescription { get; set; }

    public string? AgencyCode { get; set; }

    public bool? IsVisibleToReport { get; set; }

    public virtual ICollection<FencingPermitApplication> FencingPermitApplications { get; set; } = new List<FencingPermitApplication>();

    public virtual ICollection<LandKey> LandKeys { get; set; } = new List<LandKey>();

    public virtual ICollection<LandType> LandTypes { get; set; } = new List<LandType>();

    public virtual ICollection<LocationKey> LocationKeys { get; set; } = new List<LocationKey>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<MeterCubeRate> MeterCubeRates { get; set; } = new List<MeterCubeRate>();

    public virtual ICollection<OwnershipChangeApplication> OwnershipChangeApplications { get; set; } = new List<OwnershipChangeApplication>();

    public virtual ICollection<PlanningPermitApplication> PlanningPermitApplications { get; set; } = new List<PlanningPermitApplication>();

    public virtual ICollection<RemodelingPermitApplication> RemodelingPermitApplications { get; set; } = new List<RemodelingPermitApplication>();

    public virtual ICollection<ReportsCategory> ReportsCategories { get; set; } = new List<ReportsCategory>();

    public virtual ICollection<RequestService> RequestServices { get; set; } = new List<RequestService>();

    public virtual ICollection<RevenueCode> RevenueCodes { get; set; } = new List<RevenueCode>();

    public virtual ICollection<ServiceModeAmount> ServiceModeAmounts { get; set; } = new List<ServiceModeAmount>();

    public virtual ICollection<SpecialApplicationKey> SpecialApplicationKeys { get; set; } = new List<SpecialApplicationKey>();

    public virtual ICollection<SpecialApplicationType> SpecialApplicationTypes { get; set; } = new List<SpecialApplicationType>();

    public virtual ICollection<StageCertificationApplication> StageCertificationApplications { get; set; } = new List<StageCertificationApplication>();

    public virtual ICollection<UpgradeToFullPermitApplication> UpgradeToFullPermitApplications { get; set; } = new List<UpgradeToFullPermitApplication>();
}
