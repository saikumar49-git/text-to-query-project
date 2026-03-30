using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AwardsAndRecognization
{
    public int AwardsAndRecognizationsId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public int AboutUsId { get; set; }

    public string? AwardTitle { get; set; }

    public string? AwardDescription { get; set; }

    public DateOnly? AwardDate { get; set; }

    public string? AwardSubText { get; set; }

    public string? AwardByName { get; set; }

    public string? AwardImageUrl { get; set; }
}
