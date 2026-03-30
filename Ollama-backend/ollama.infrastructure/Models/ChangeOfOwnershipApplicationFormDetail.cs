using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ChangeOfOwnershipApplicationFormDetail
{
    public int ChangeOfOwnershipApplicationFormDetailsId { get; set; }

    public int? OwnershipChangeApplicationId { get; set; }

    public int CreatedBy { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? CurrentOwner { get; set; }

    public bool? NewOwner { get; set; }

    public string? CurrentPermitHolderInformation { get; set; }

    public string? NewOwnerInformation { get; set; }

    public string? PropertyInformation { get; set; }
}
