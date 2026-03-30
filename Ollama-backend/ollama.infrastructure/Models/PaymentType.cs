using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PaymentType
{
    public int PaymentTypeId { get; set; }

    public string PaymentTypeName { get; set; } = null!;

    public bool IsActive { get; set; }
}
