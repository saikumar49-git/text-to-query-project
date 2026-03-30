using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public bool? Active { get; set; }

    public bool? IsDeleted { get; set; }
}
