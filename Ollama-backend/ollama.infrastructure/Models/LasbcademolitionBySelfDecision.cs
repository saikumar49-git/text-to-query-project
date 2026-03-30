using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcademolitionBySelfDecision
{
    public int DemolitionPermitDecisionId { get; set; }

    public int? DemolitionPermitId { get; set; }

    public int? DemolitionPermitDetailId { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public string? Decision { get; set; }

    public int? FieldOfficerUid { get; set; }

    public int? StatusNumber { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
