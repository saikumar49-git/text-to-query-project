using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DemolitionSiteInspectionReport
{
    public int DemolitionSiteInspectionReportId { get; set; }

    public int? DemolitionPermitId { get; set; }

    public string? InspectorInformation { get; set; }

    public string? BuildingInformation { get; set; }

    public string? GeneralInformation { get; set; }

    public string? StructuralAssessment { get; set; }

    public string? HazardousMaterialsAssessment { get; set; }

    public string? UtilitiesServices { get; set; }

    public string? SiteSafetyAssessment { get; set; }

    public string? EnvironmentalConsiderations { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
