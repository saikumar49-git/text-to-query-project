using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AuditLog
{
    public int LogId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UserId { get; set; }

    public string? Service { get; set; }

    public string? Category { get; set; }

    public string? Activity { get; set; }

    public string? Status { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }
}
