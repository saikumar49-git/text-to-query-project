using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitApplicationFormDetail
{
    public int FencingPermitApplicationFormDetailId { get; set; }

    public int? FencingPermitApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public int? FencingPermitApplicationFormTypeId { get; set; }

    public int? FencingPermitBuildingTypeId { get; set; }

    public int? ApplicantTitleOwnerClassId { get; set; }

    public int? StateId { get; set; }

    public int? LgaId { get; set; }

    public int? CityId { get; set; }

    public int? DistrictId { get; set; }

    public int? TitleId { get; set; }

    public int? ServiceModeId { get; set; }

    public int? ServiceModeAmountId { get; set; }

    public int? FencingPermitApplicationStatusId { get; set; }

    public string? TitleOwnerCorporateName { get; set; }

    public string? TitleOwnerFirstName { get; set; }

    public string? TitleOwnerLastName { get; set; }

    public string? TitleOwnerMiddleName { get; set; }

    public string? ApplicantFirstName { get; set; }

    public string? ApplicantAddress { get; set; }

    public string? ApplicantTelephoneNumber { get; set; }

    public string? ApplicantEmailAddress { get; set; }

    public int? LocationofLand { get; set; }

    public decimal? Area { get; set; }

    public string? LandAcquiredFrom { get; set; }

    public string? TypeofInterestonTitle { get; set; }

    public string? EvidenceofOwnerShip { get; set; }

    public string? Drainage { get; set; }

    public string? PipedWater { get; set; }

    public string? Electricity { get; set; }

    public string? RefuseCollectionPoint { get; set; }

    public int? AgencyId { get; set; }

    public string? RequestServiceId { get; set; }

    public int? LandAcquiredTypeId { get; set; }

    public int? TitleInterestTypeId { get; set; }

    public int? TitleApplicant { get; set; }

    public string? ApplicantMiddleName { get; set; }

    public string? ApplicantLastName { get; set; }

    public string? WaterSprinkler { get; set; }

    public string? UndergroundWaterTank { get; set; }

    public string? Borehole { get; set; }

    public string? AllIndicatedonDrawings { get; set; }

    public string? IsPlotCornerPiece { get; set; }

    public DateOnly? SurveyPlanDate { get; set; }

    public string? SurveyPlanOrigin { get; set; }

    public string? SurveyPlanRefNo { get; set; }

    public string? IsSurveyTitleCorrespond { get; set; }

    public string? IsAccessToLandDefined { get; set; }

    public string? StreetName { get; set; }

    public string? SurveySingularorBeacon { get; set; }

    public int? ExistingStructures { get; set; }

    public int? ProposedStructures { get; set; }

    public string? StructuresJsonData { get; set; }

    public int? TotalUnits { get; set; }

    public string? LandAquiredFromOtherType { get; set; }

    public string? PropertyAddress { get; set; }

    public string? PropertyName { get; set; }

    public int? PropertyState { get; set; }

    public int? PropertyLga { get; set; }

    public int? PropertyCity { get; set; }

    public int? PropertyDistrict { get; set; }

    public string? ParcelNumber { get; set; }

    public string? Zoning { get; set; }

    public decimal? PlotSize { get; set; }

    public int? LicenseNumber { get; set; }

    public int? FenceType { get; set; }

    public int? FencePurpose { get; set; }

    public decimal? FenceHeight { get; set; }

    public decimal? FenceLength { get; set; }

    public decimal? DistanceFromPropertyLines { get; set; }

    public int? IsFenceReplacingExistingFence { get; set; }

    public string? ExistingFenceDetails { get; set; }

    public int? AnyEasementsOnTheProperty { get; set; }

    public string? PropertyEasementDetails { get; set; }

    public int? PropertyLocation { get; set; }

    public string? OtherFenceType { get; set; }

    public string? OtherPurposeofFenceText { get; set; }

    public virtual LandAcquiredType? LandAcquiredType { get; set; }

    public virtual UserTitle? TitleApplicantNavigation { get; set; }

    public virtual TitleInterestType? TitleInterestType { get; set; }
}
