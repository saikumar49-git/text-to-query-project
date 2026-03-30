using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SubLandTypeV2
{
    public int SubLandTypeId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SubLandTypeName { get; set; }

    public bool? IsVisibleForRestamping { get; set; }

    public int? LandCategoryId { get; set; }

    public int SubLandTypeUniqueId { get; set; }
}
