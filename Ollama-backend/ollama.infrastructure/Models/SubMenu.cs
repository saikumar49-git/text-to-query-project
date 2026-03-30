using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SubMenu
{
    public int SubMenuId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? MainMenuId { get; set; }

    public virtual MainMenu? MainMenu { get; set; }

    public virtual ICollection<MenuContent> MenuContents { get; set; } = new List<MenuContent>();
}
