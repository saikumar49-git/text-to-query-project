using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcacontraventionActivity
{
    public int ActivityId { get; set; }

    public int? ContraventionId { get; set; }

    public string? ActivityType { get; set; }

    public string? Activity { get; set; }

    public string? NextAction { get; set; }

    public string? Comments { get; set; }

    public bool? IsActive { get; set; }

    public int? UserId { get; set; }

    public int? AssignedTo { get; set; }

    public bool? ReworkTo { get; set; }

    public bool? IsExpired { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Action { get; set; }

    public int? ActionId { get; set; }

    public bool? IsForwarded { get; set; }

    public bool? IsDemolition { get; set; }
}
