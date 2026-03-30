using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Role1
{
    public int RoleId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? RoleName { get; set; }

    public string? RoleDescription { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }
}
