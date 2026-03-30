using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitAssessmentFeeCalculation
{
    public int AssessmentFeeCalculationsId { get; set; }

    public int? LocationId { get; set; }

    public int? LandTypeId { get; set; }

    public decimal? LandArea { get; set; }

    public int? NumberOfFloors { get; set; }

    public string? FloorsData { get; set; }

    public int? RemodelingPermitApplicationId { get; set; }

    public int? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? TotalAmount { get; set; }

    public bool? IsSpecialApplication { get; set; }

    public int? SpecialApplicationTypeId { get; set; }

    public int? SpecialApplicationRateCategoryId { get; set; }

    public int? NoofPumps { get; set; }

    public int? TankVolume { get; set; }

    public string? CalculationSnapshot { get; set; }

    public int? RemodelingPermitFormTypeId { get; set; }

    public int? NoofTanks { get; set; }

    public decimal? StationBuildingVolume { get; set; }

    public bool? CondonationFee { get; set; }

    public bool? PenalFee { get; set; }

    public int? PenalFactor { get; set; }

    public int? TotalUnits { get; set; }

    public virtual LandType? LandType { get; set; }

    public virtual Location? Location { get; set; }

    public virtual RemodelingPermitApplication? RemodelingPermitApplication { get; set; }

    public virtual PlanningPermitApplicationFormType? RemodelingPermitFormType { get; set; }

    public virtual SpecialApplicationRateCategory? SpecialApplicationRateCategory { get; set; }

    public virtual SpecialApplicationType? SpecialApplicationType { get; set; }
}
