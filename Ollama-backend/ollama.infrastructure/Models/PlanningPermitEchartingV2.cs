using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitEchartingV2
{
    public int PlanningPermitEchartingApplicationId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public int? PlanningPermitStatusDetailId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string SurveyId { get; set; } = null!;

    public string? CreateStatusCode { get; set; }

    public string? CreateSurveyStatus { get; set; }

    public string? EchartingSurveyStatus { get; set; }

    public string? EchartingStatusCode { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public string? Bearings { get; set; }

    public string? BaseMapExtractionResults { get; set; }

    public string? CreateMessage { get; set; }
}
