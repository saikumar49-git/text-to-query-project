using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingSiteInspectionReport
{
    public int FencingSiteInspectionReportId { get; set; }

    public bool? IsActive { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? InspectionDate { get; set; }

    public string? InspectorFirstName { get; set; }

    public string? InspectorMiddleName { get; set; }

    public string? InspectorLastName { get; set; }

    public string? InspectorTelephone { get; set; }

    public string? InspectorEmail { get; set; }

    public string? ApplicantFirstName { get; set; }

    public string? ApplicantMiddleName { get; set; }

    public string? ApplicantLastName { get; set; }

    public string? ApplicantTelephone { get; set; }

    public string? ApplicantEmail { get; set; }

    public string? StreetAddress { get; set; }

    public string? ZipCode { get; set; }

    public int? City { get; set; }

    public int? State { get; set; }

    public string? PermitApplicationNumber { get; set; }

    public int? PropertyType { get; set; }

    public string? CurrentLandUse { get; set; }

    public string? ZoningType { get; set; }

    public int? ProposedFencingMaterial { get; set; }

    public string? ProposedFenceHeight { get; set; }

    public int? FenceLocation { get; set; }

    public string? TotalFenceLength { get; set; }

    public int? PurposeOfFence { get; set; }

    public int? Topography { get; set; }

    public int? Vegetation { get; set; }

    public string? ExisttingStructures { get; set; }

    public int? SoilCondition { get; set; }

    public int? WaterDraingae { get; set; }

    public string? UtilityEasements { get; set; }

    public string? AdjacentPropertyImpact { get; set; }

    public string? ZoningRequirements { get; set; }

    public string? SetbackRequirements { get; set; }

    public string? HeightRestrictions { get; set; }

    public string? MaterialRestrictions { get; set; }

    public string? HistoricalPreservation { get; set; }

    public string? EnvironmentalConsiderations { get; set; }

    public string? InspectorsComments { get; set; }

    public int? RecomendationApproval { get; set; }

    public string? RecomendationConditions { get; set; }

    public string? InspectorsSignature { get; set; }

    public DateTime? InspectorsDate { get; set; }

    public string? ApplicantSignature { get; set; }

    public DateTime? ApplicantDate { get; set; }

    public int? FencingPermitApplicationId { get; set; }

    public virtual City? CityNavigation { get; set; }

    public virtual FenceLocation? FenceLocationNavigation { get; set; }

    public virtual FencingMaterial? ProposedFencingMaterialNavigation { get; set; }

    public virtual FencePurpose? PurposeOfFenceNavigation { get; set; }

    public virtual RecommendationsApproval? RecomendationApprovalNavigation { get; set; }

    public virtual SoilCondition? SoilConditionNavigation { get; set; }

    public virtual State? StateNavigation { get; set; }

    public virtual Topography? TopographyNavigation { get; set; }

    public virtual Vegetation? VegetationNavigation { get; set; }

    public virtual WaterDrainage? WaterDraingaeNavigation { get; set; }
}
