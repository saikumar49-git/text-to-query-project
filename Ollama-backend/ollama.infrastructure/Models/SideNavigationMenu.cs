using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SideNavigationMenu
{
    public int NavigationId { get; set; }

    public int? RoleId { get; set; }

    public string? Name { get; set; }

    public string? Link { get; set; }

    public int? Level { get; set; }

    public string? IconPath { get; set; }

    public int? ParentId { get; set; }

    public string? Permission { get; set; }

    public bool? MainMenu { get; set; }

    public string? StyleClass { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
