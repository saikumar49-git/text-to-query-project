using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UserRole2
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int RoleId { get; set; }

    public virtual Role2 Role { get; set; } = null!;

    public virtual User3 User { get; set; } = null!;
}
