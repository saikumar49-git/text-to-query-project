using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitSiteInspectionReportV1
{
    public int RenovationPermitSiteInspectionReportId { get; set; }

    public int? PermitId { get; set; }

    public string? AgencyName { get; set; }

    public string? PermitNumber { get; set; }

    public string? Address { get; set; }

    public DateTime? InspectionDate { get; set; }

    public string? InspectionTime { get; set; }

    public string? GeneralInformation { get; set; }

    public string? StructuralInfo { get; set; }

    public string? ElectricalInfo { get; set; }

    public string? PlumbingInfo { get; set; }

    public string? Hvacinfo { get; set; }

    public string? FireAlarmInfo { get; set; }

    public string? ComplianceInfo { get; set; }

    public string? InspectionInfo { get; set; }

    public string? AdditionalComments { get; set; }

    public string? InspectorInfo { get; set; }

    public DateTime? ContractorAcknowledgmentDate { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
