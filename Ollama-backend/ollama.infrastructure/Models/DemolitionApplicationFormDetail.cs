using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DemolitionApplicationFormDetail
{
    public int DemolitionApplicationFormDetailId { get; set; }

    public int? DemolitionPermitId { get; set; }

    public string? ApplicantInformation { get; set; }

    public string? PropertyInformation { get; set; }

    public string? BuildingInformation { get; set; }

    public string? DetailsInformation { get; set; }

    public string? EnvironmentalInformation { get; set; }

    public string? UtilityDisconnections { get; set; }

    public string? WasteDisposal { get; set; }

    public string? ContractorInformation { get; set; }

    public string? CertificationInformation { get; set; }

    public int? ServiceModeId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
