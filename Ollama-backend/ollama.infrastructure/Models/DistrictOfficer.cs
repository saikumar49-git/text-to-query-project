using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DistrictOfficer
{
    public int DistrictOfficerId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int UserId { get; set; }

    public int DistrictId { get; set; }

    public virtual District District { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
