using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcascheduledDate
{
    public int ScheduledDateId { get; set; }

    public int? AuthorizationCommenceId { get; set; }

    public DateTime? ScheduledDate { get; set; }

    public int? ApplicationStageId { get; set; }

    public bool? IsRescheduled { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? RequestServiceId { get; set; }

    public bool? IsInspected { get; set; }
}
