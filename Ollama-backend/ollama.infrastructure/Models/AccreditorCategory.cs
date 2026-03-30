using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AccreditorCategory
{
    public int CategoryId { get; set; }

    public string CategoryCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Fee { get; set; }
}
