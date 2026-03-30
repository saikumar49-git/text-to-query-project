using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevenueHead
{
    public int RevenueHeadId { get; set; }

    public int RevenueMinistryId { get; set; }

    public string RevenueHeadName { get; set; } = null!;

    public string RevenueKey { get; set; } = null!;

    public string? AgencyCode { get; set; }

    public string? RevenueCode { get; set; }

    public string? LegacyAgencyCode { get; set; }

    public string? LegacyRevenueCode { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual RevenueMinistry RevenueMinistry { get; set; } = null!;
}
