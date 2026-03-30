using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Lasbcastatus
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public int? StatusId { get; set; }

    public int? RequestServiceId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? ApplicantStatusMessage { get; set; }
}
