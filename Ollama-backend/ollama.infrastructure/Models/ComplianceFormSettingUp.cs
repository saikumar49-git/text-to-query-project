using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ComplianceFormSettingUp
{
    public int FencingComplianceFormSettingUpId { get; set; }

    public int? ApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? UserId { get; set; }

    public int? RequestServiceId { get; set; }

    public string? ProjectTitle { get; set; }

    public string? NameOfOwner { get; set; }

    public string? SiteLocation { get; set; }

    public string? DateOfCommencement { get; set; }

    public string? SitePlan { get; set; }

    public string? BuildingLine { get; set; }

    public string? ProfileLine { get; set; }

    public string? DatumLine { get; set; }

    public string? Levels { get; set; }

    public string? DeviationApproved { get; set; }

    public string? Justification { get; set; }

    public string? GeneralConclusion { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DateOfSubmission { get; set; }

    public bool? IsSignatureCompleted { get; set; }

    public string? Signatures { get; set; }

    public string? NameOfEngineer { get; set; }

    public int? ApplicationStageId { get; set; }

    public int? PlotNo { get; set; }
}
