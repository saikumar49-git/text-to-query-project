using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Policy
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Role3> Roles { get; set; } = new List<Role3>();
}
