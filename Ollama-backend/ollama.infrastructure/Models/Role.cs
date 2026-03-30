using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? RoleName { get; set; }

    public string? RoleDescription { get; set; }

    public virtual ICollection<PermissionRole> PermissionRoles { get; set; } = new List<PermissionRole>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
