using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitApplicationStatusV2
{
    public int PlanningPermitApplicationStatusId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RequestServiceId { get; set; }

    public string? StatusName { get; set; }

    public string? StatusMessage { get; set; }

    public string? StatusNumber { get; set; }
}
