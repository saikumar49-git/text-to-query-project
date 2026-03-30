using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevenueCode
{
    public int RevenueCodeId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string RevenueType { get; set; } = null!;

    public string RevenueCode1 { get; set; } = null!;

    public int AgencyId { get; set; }

    public virtual Agency Agency { get; set; } = null!;
}
