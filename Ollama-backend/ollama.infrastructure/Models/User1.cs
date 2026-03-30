using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class User1
{
    public int UserId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsActive { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public bool? IsLocked { get; set; }

    public DateTime? LockedOutEndTime { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
