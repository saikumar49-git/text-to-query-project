using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class StageCertificationsDecision
{
    public int ApplicationDecisionId { get; set; }

    public int? ApplicationId { get; set; }

    public int? UserId { get; set; }

    public int? AssignedTo { get; set; }

    public string? Comment { get; set; }

    public bool? IsApproved { get; set; }

    public int? ApplicationStageId { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsFormUpload { get; set; }

    public bool? IsRescheduleRequested { get; set; }

    public int? RequestServiceId { get; set; }

    public int? InspectedDateId { get; set; }

    public string? RequestedDocuments { get; set; }
}
