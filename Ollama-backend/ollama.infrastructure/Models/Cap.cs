using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Cap
{
    public int DocumentId { get; set; }

    public string? ApplicationId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FileContentType { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? Upload { get; set; }

    public string? Category { get; set; }

    public string? Comments { get; set; }

    public string? Email { get; set; }

    public int? ApplicationNumber { get; set; }

    public bool IsApplicationRejected { get; set; }
}
