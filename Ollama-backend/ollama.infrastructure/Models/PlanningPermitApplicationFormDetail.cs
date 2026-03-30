using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitApplicationFormDetail
{
    public int PlanningPermitApplicationFormDetailId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public int? PlanningPermitApplicationFormTypeId { get; set; }

    public int? PlanningPermitBuildingTypeId { get; set; }

    public int? ApplicantTitleOwnerClassId { get; set; }

    public int? StateId { get; set; }

    public int? LgaId { get; set; }

    public int? CityId { get; set; }

    public int? DistrictId { get; set; }

    public int? TitleId { get; set; }

    public int? ServiceModeId { get; set; }

    public int? ServiceModeAmountId { get; set; }

    public int? PlanningPermitApplicationStatusId { get; set; }

    public string? TitleOwnerCorporateName { get; set; }

    public string? TitleOwnerFirstName { get; set; }

    public string? TitleOwnerLastName { get; set; }

    public string? TitleOwnerMiddleName { get; set; }

    public string? ApplicantFirstName { get; set; }

    public string? ApplicantAddress { get; set; }

    public string? ApplicantTelephoneNumber { get; set; }

    public string? ApplicantEmailAddress { get; set; }

    public string? ArchitectName { get; set; }

    public string? ArchitectAddress { get; set; }

    public string? ArchitectTelephoneNumber { get; set; }

    public string? ArchitectEmailAddress { get; set; }

    public string? ArchitectRconumber { get; set; }

    public string? EngineerName { get; set; }

    public string? EngineerAddress { get; set; }

    public string? EngineerTelephoneNumber { get; set; }

    public string? EngineerEmailAddress { get; set; }

    public string? EngineerArcon { get; set; }

    public string? LocationofLand { get; set; }

    public string? Width { get; set; }

    public string? Length { get; set; }

    public decimal? Area { get; set; }

    public string? AllPillarsonSurveyPlan { get; set; }

    public string? LandAcquiredFrom { get; set; }

    public string? TypeofInterestonTitle { get; set; }

    public string? EvidenceofOwnerShip { get; set; }

    public string? Drainage { get; set; }

    public string? PipedWater { get; set; }

    public string? Electricity { get; set; }

    public string? RefuseCollectionPoint { get; set; }

    public int? AgencyId { get; set; }

    public string? RequestServiceId { get; set; }

    public int? IsFencingPermitAvailable { get; set; }

    public string? FencingPermitNumber { get; set; }

    public int? LandAcquiredTypeId { get; set; }

    public int? TitleInterestTypeId { get; set; }

    public int? TitleApplicant { get; set; }

    public string? ApplicantMiddleName { get; set; }

    public string? ApplicantLastName { get; set; }

    public string? WaterSprinkler { get; set; }

    public string? UndergroundWaterTank { get; set; }

    public string? Borehole { get; set; }

    public string? FireFightingEquipment { get; set; }

    public string? FireAlarm { get; set; }

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

    public string? MechanicalEngineerName { get; set; }

    public string? MechanicalEngineerAddress { get; set; }

    public string? MechanicalEngineerTelephoneNumber { get; set; }

    public string? MechanicalEngineerEmail { get; set; }

    public string? MechanicalArconNumber { get; set; }

    public string? ElectricalEngineerName { get; set; }

    public string? ElectricalEngineerAddress { get; set; }

    public string? ElectricalEngineerTelephoneNumber { get; set; }

    public string? ElectricalEngineerEmail { get; set; }

    public string? ElectricalArconNumber { get; set; }

    public int? PlanningPermitTypeId { get; set; }

    public virtual LandAcquiredType? LandAcquiredType { get; set; }

    public virtual PlanningPermitApplication? PlanningPermitApplication { get; set; }

    public virtual State? State { get; set; }

    public virtual UserTitle? TitleApplicantNavigation { get; set; }

    public virtual TitleInterestType? TitleInterestType { get; set; }
}
