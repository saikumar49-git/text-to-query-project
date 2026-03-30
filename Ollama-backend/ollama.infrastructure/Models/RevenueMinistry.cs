using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevenueMinistry
{
    public int RevenueMinistryId { get; set; }

    public string MinistryName { get; set; } = null!;

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<RevenueHead> RevenueHeads { get; set; } = new List<RevenueHead>();
}
