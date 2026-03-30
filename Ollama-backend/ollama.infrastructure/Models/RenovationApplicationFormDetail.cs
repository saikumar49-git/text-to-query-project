using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationApplicationFormDetail
{
    public int RenovationApplicationFormDetailId { get; set; }

    public int? RenovationPermitId { get; set; }

    public string? ApplicantInformation { get; set; }

    public string? PropertyInformation { get; set; }

    public string? RenovationDetails { get; set; }

    public string? CertificationInformation { get; set; }

    public int? ServiceModeId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
