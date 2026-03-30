using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitAssessmentFeeCalculationsV2
{
    public int RenovationPermitAssessmentFeeCalculationsId { get; set; }

    public int? CityId { get; set; }

    public decimal? LandArea { get; set; }

    public string? SubLandTypeIds { get; set; }

    public string? SpecialApplicationKeyIds { get; set; }

    public int? RenovationPermitApplicationId { get; set; }

    public int? RequestServiceId { get; set; }

    public bool? PremiumArea { get; set; }

    public bool? CondonationFee { get; set; }

    public bool? PenalFee { get; set; }

    public int? MultiplyFactor { get; set; }

    public int? TotalUnits { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? ProposedStructures { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CalculationsData { get; set; }

    public int? MaxNumberOfFloors { get; set; }

    public bool? IsDiscountApplied { get; set; }

    public decimal? DiscountedAmount { get; set; }

    public decimal? Discount { get; set; }

    public bool? ContraventionFee { get; set; }
}
