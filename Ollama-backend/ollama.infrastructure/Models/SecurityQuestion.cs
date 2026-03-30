using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SecurityQuestion
{
    public int SecurityQuestionId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string Question { get; set; } = null!;

    public int? ApplicantTypeId { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
