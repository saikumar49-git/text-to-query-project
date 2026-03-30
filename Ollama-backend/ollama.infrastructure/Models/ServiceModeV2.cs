using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ServiceModeV2
{
    public int ServiceModeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ServiceMode { get; set; }

    public string? ServiceModeName { get; set; }

    public string? ServiceModeDescription { get; set; }
}
