using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevalidationConstructionStatus
{
    public int RevalidationConstructionId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ConstructionStatus { get; set; }
}
