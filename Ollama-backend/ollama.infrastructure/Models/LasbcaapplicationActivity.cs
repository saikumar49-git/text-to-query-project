using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcaapplicationActivity
{
    public int ActivityId { get; set; }

    public int? AuthorizationCommenceId { get; set; }

    public string ActivityType { get; set; } = null!;

    public string? Activity { get; set; }

    public string? NextActivity { get; set; }

    public int? StageId { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? AssignedTo { get; set; }

    public int? UserId { get; set; }

    public string? RequestedDocuments { get; set; }

    public int? ReworkTo { get; set; }

    public string? Comments { get; set; }

    public int? ForwardToGm { get; set; }

    public bool? IsGmapproves { get; set; }
}
