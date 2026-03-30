using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ContraventionTransaction
{
    public int TranId { get; set; }

    public int? ContraventionId { get; set; }

    public string? StatusMessage { get; set; }

    public string? AcctionTaken { get; set; }

    public string? Comment { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
