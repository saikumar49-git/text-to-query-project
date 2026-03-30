using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UpgradePermitSiteInspectionReport
{
    public int UpgradePermitSiteInspectionReportId { get; set; }

    public int UpgradePermitApplicationId { get; set; }

    public bool IsActive { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime DateOfSubmission { get; set; }

    public int StatusId { get; set; }

    public string? PermitNumber { get; set; }

    public DateOnly InspectionDate { get; set; }

    public string? InspectionTime { get; set; }

    public string InspectorName { get; set; } = null!;

    public int? InspectorId { get; set; }

    public string? ContactInfo { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectAddress { get; set; }

    public string? OwnerDeveloper { get; set; }

    public string? Contractor { get; set; }

    public string? ArchitectEngineer { get; set; }

    public string? ConstructionType { get; set; }

    public string? ProvisionalPermitNumber { get; set; }

    public string? StageOfConstruction { get; set; }

    public string? ComplianceWithApprovedPlans { get; set; }

    public string? ComplianceWithApprovedPlansComment { get; set; }

    public string? ZoningAndSafetyRegulations { get; set; }

    public string? ZoningAndSafetyRegulationsComment { get; set; }

    public string? StructuralIntegrity { get; set; }

    public string? StructuralIntegrityComments { get; set; }

    public string? ElectricalWork { get; set; }

    public string? ElectricalWorkComments { get; set; }

    public string? PlumbingWork { get; set; }

    public string? PlumbingWorkComments { get; set; }

    public string? FireSafety { get; set; }

    public string? FireSafetyComments { get; set; }

    public string? EnvironmentalCompliance { get; set; }

    public string? EnvironmentalComplianceComments { get; set; }

    public string? Aspect { get; set; }

    public string? Results { get; set; }

    public string? OtherInspectionsComments { get; set; }

    public string? PermitRecommended { get; set; }

    public string? RecommendedReason { get; set; }

    public string? FurtherActions { get; set; }

    public string? SpecifyDetailsComments { get; set; }

    public string? GeneralInspectorsName { get; set; }

    public string? InspectorSignature { get; set; }

    public DateOnly InspectorSignatureDate { get; set; }

    public string? OwnerDeveloperName { get; set; }

    public string? OwnerDeveloperSignature { get; set; }

    public DateOnly OwnerDeveloperDate { get; set; }

    public string? FinalComments { get; set; }
}
