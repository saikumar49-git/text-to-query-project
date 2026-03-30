using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevalidationApplicationFormDetail
{
    public int RevalidationApplicationFormDetailId { get; set; }

    public int? RevalidationPermitId { get; set; }

    public string? ApplicantInformation { get; set; }

    public string? BuildingInformation { get; set; }

    public DateTime? DateOfOriginalPermitIssuance { get; set; }

    public string? PropertyInformation { get; set; }

    public int? CurrentUseOfBuilding { get; set; }

    public string? CurrentUseOfBuildingOtherText { get; set; }

    public int? TypeOfBuilding { get; set; }

    public string? TypeOfBuildingOtherText { get; set; }

    public string? ProjectInformation { get; set; }

    public string? CertificationInformation { get; set; }

    public int? ServiceModeId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
