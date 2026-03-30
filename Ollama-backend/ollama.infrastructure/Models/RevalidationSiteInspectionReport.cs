using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevalidationSiteInspectionReport
{
    public int RevalidationSiteInpsectionReportId { get; set; }

    public int? RevalidationPermitId { get; set; }

    public string? GeneralInformation { get; set; }

    public string? PurposeInspection { get; set; }

    public string? SiteInformation { get; set; }

    public string? StructuralIntegrity { get; set; }

    public string? AdherenceApprovedPlans { get; set; }

    public string? ElectricalSystems { get; set; }

    public string? PlumbingSystems { get; set; }

    public string? FireSafety { get; set; }

    public string? AccessibilityCompliance { get; set; }

    public string? EnvironmentalConsiderations { get; set; }

    public string? OthersChecklistText { get; set; }

    public string? ObservationInformation { get; set; }

    public string? ConclusionInformation { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
