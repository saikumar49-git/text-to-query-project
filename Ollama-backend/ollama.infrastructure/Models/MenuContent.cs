using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MenuContent
{
    public int MenuContentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? ImagePath { get; set; }

    public string? VideoPath { get; set; }

    public int? SubMenuId { get; set; }

    public virtual SubMenu? SubMenu { get; set; }
}
