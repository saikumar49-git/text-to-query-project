using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitEcharting
{
    public int PlanningPermitEchartingApplicationId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string SurveyId { get; set; } = null!;

    public string SurveyBase64 { get; set; } = null!;

    public string? EchartingResultBase64 { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public int? PlanningPermitApplicationDetailId { get; set; }

    public string? Bearings { get; set; }

    public string? SurveyPlanNumber { get; set; }

    public string? BaseMapExtractionResults { get; set; }

    public virtual PlanningPermitApplicationDetail? PlanningPermitApplicationDetail { get; set; }
}
