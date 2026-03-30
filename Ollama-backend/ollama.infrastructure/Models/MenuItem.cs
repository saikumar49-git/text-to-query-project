using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MenuItem
{
    public int Id { get; set; }

    public bool IsActive { get; set; }

    public string Name { get; set; } = null!;

    public int? Level { get; set; }

    public string? Icon { get; set; }

    public string? Link { get; set; }

    public string? Permission { get; set; }

    public int? MainMenuId { get; set; }

    public int? ParentId { get; set; }

    public bool? FeatureOff { get; set; }

    public string? StyleClass { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
