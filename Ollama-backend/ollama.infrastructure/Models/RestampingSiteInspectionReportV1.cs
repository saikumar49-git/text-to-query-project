using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RestampingSiteInspectionReportV1
{
    public int RestampingSiteInpsectionReportId { get; set; }

    public int? PermitId { get; set; }

    public DateTime? DateOfInspection { get; set; }

    public string? TimeOfInspection { get; set; }

    public string? ProjectInformation { get; set; }

    public string? InspectionDetails { get; set; }

    public string? InspectionFindings { get; set; }

    public string? RequiredActions { get; set; }

    public string? InspectorsInformation { get; set; }

    public string? ContractorAcknowledgmentInformation { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
