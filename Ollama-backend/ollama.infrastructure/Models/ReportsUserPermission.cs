using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ReportsUserPermission
{
    public int ReportPermissionId { get; set; }

    public int UserId { get; set; }

    public int RoleId { get; set; }

    public int CategoryId { get; set; }

    public int SubCategoryId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual User User { get; set; } = null!;
}
