using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Role3
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<User4> User4s { get; set; } = new List<User4>();

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();
}
