using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PermissionRole
{
    public int PermissionId { get; set; }

    public int Id { get; set; }

    public int RoleId { get; set; }

    public bool IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Role Role { get; set; } = null!;
}
