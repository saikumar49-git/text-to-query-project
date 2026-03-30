using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MeterCubeRateV2
{
    public int MeterCubeRateId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? LandCategoryId { get; set; }

    public int? CategoryId { get; set; }

    public int? RangeId { get; set; }

    public decimal? MeterCubeRate { get; set; }
}
