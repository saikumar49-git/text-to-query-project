using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UserPermission
{
    public int PermissionId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? UserId { get; set; }

    public int? ScreenId { get; set; }

    public bool? Reader { get; set; }

    public bool? Contributor { get; set; }

    public bool? Owner { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
