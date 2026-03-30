using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcaFeeAssessment
{
    public int FeeAssessmentId { get; set; }

    public int? DemolitionPermitId { get; set; }

    public double? AssessmentFee { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
