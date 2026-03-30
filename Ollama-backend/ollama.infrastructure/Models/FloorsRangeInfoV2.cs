using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FloorsRangeInfoV2
{
    public int FloorsRangeInfoId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? NumberOfFloorsMin { get; set; }

    public int? NumberOfFloorsMax { get; set; }

    public int? RangeId { get; set; }
}
