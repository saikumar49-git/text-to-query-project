using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcainsuranceDepartment
{
    public int InsuranceDepartmentId { get; set; }

    public int? AuthorizationCommenceId { get; set; }

    public int? RequestServiceId { get; set; }

    public int? UserId { get; set; }

    public int? InsuranceTeamId { get; set; }

    public string? InsuranceTeamFeedback { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? StatusId { get; set; }

    public int? ReworkStatus { get; set; }

    public int? ReworkTo { get; set; }

    public string? Status { get; set; }

    public int? FileId { get; set; }

    public bool? IsDidaction { get; set; }

    public bool? IsIoaction { get; set; }
}
