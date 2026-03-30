using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RequestServiceFlowStep
{
    public int RequestServiceFlowStepsId { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public int RequestServiceId { get; set; }

    public string? RequestServiceFlowStepsDescription { get; set; }

    public int? RankId { get; set; }
}
