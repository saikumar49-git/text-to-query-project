using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Lasbcastage
{
    public int Id { get; set; }

    public string? Stage { get; set; }

    public string? Description { get; set; }

    public int? StageId { get; set; }

    public int? RequestServiceId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
