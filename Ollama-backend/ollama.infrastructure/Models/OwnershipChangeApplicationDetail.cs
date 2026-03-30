using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class OwnershipChangeApplicationDetail
{
    public int OwnershipChangeApplicationDetailId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? OwnershipChangeApplicationId { get; set; }

    public int? OwnershipChangeApplicationStatusId { get; set; }

    public string? Docomments { get; set; }

    public string? Rocomments { get; set; }

    public string? Dodecision { get; set; }

    public string? Rodecision { get; set; }

    public int? DistrictId { get; set; }

    public int? ServiceModeId { get; set; }

    public int? ServiceModeAmountId { get; set; }

    public string? Status { get; set; }

    public virtual OwnershipChangeApplication? OwnershipChangeApplication { get; set; }

    public virtual ICollection<OwnershipChangeApplicationFile> OwnershipChangeApplicationFiles { get; set; } = new List<OwnershipChangeApplicationFile>();

    public virtual OwnershipChangeApplicationStatus? OwnershipChangeApplicationStatus { get; set; }
}
