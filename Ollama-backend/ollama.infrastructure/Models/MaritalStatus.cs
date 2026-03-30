using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MaritalStatus
{
    public int MaritalStatusId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Status { get; set; }

    public string? Suffix { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
