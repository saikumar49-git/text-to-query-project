using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Screen
{
    public int ScreenId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ScreenName { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
