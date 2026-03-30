using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class StandardizedTaxRate
{
    public int StandardizedTaxRatesId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? Lgaid { get; set; }

    public decimal Rate { get; set; }

    public decimal BaseMinimumAmout { get; set; }
}
