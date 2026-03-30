using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Role2
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<UserRole2> UserRole2s { get; set; } = new List<UserRole2>();
}
