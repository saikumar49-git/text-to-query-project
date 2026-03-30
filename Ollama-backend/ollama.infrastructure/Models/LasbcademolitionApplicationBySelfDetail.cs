using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcademolitionApplicationBySelfDetail
{
    public int DemolitionPermitDetailId { get; set; }

    public int? DemolitionPermitId { get; set; }

    public int? DemolitionPermitStatusId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public DateTime? ScheduleDate1 { get; set; }

    public DateTime? ScheduleDate2 { get; set; }

    public DateTime? ScheduleDate3 { get; set; }

    public int? TeamLeadId { get; set; }

    public int? FieldOfficerId { get; set; }

    public int? DemolitionTeamLeadId { get; set; }

    public DateTime? DemolitionDate1 { get; set; }

    public DateTime? DemolitionDate2 { get; set; }

    public DateTime? DemolitionDate3 { get; set; }

    public int? AssessmentFee { get; set; }

    public virtual LasbcademolitionApplicationBySelf? DemolitionPermit { get; set; }
}
