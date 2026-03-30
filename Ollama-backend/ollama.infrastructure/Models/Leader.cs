using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Leader
{
    public int LeadersId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public int AboutUsId { get; set; }

    public string? LeaderName { get; set; }

    public string? LeaderDesignation { get; set; }

    public string? LeaderImageUrl { get; set; }
}
