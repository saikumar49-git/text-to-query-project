using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitEcharting
{
    public int FencingPermitEchartingApplicationId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string SurveyId { get; set; } = null!;

    public string? SurveyBase64 { get; set; }

    public string? EchartingResultBase64 { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public int? FencingPermitApplicationDetailId { get; set; }

    public string? Bearings { get; set; }

    public string? SurveyPlanNumber { get; set; }

    public string? BaseMapExtractionResults { get; set; }

    public int? FencingPermitApplicationId { get; set; }

    public string? CreateStatusCode { get; set; }

    public string? CreateSurveyStatus { get; set; }

    public string? CreateMessage { get; set; }

    public string? EchartingSurveyStatus { get; set; }

    public string? EchartingStatusCode { get; set; }

    public virtual FencingPermitApplicationDetail? FencingPermitApplicationDetail { get; set; }
}
