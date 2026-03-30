using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UserActivity
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string ActivityType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string IpAddress { get; set; } = null!;

    public virtual User5 User { get; set; } = null!;
}
