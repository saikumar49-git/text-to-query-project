using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RestampingPlanningApplicationFile
{
    public int RestampingPlanningFileId { get; set; }

    public int? RestampingPlanningId { get; set; }

    public string FileName { get; set; } = null!;

    public string? Type { get; set; }

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StampingStatus { get; set; }

    public virtual RestampingPlanningApplication? RestampingPlanning { get; set; }
}
