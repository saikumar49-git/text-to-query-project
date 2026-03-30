using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FloorsRangeV2
{
    public int FloorsRangeId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Description { get; set; }

    public int? RangeId { get; set; }
}
