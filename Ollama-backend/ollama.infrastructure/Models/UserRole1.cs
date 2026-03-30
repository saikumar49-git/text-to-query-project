using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UserRole1
{
    public int UserRoleId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
