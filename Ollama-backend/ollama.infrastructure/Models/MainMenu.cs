using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MainMenu
{
    public int MainMenuId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<SubMenu> SubMenus { get; set; } = new List<SubMenu>();
}
