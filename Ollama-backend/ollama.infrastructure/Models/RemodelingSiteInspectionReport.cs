using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingSiteInspectionReport
{
    public int RemodelingSiteInspectionReportId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? PermitNumber { get; set; }

    public DateTime? InspectionDate { get; set; }

    public string? ProjectStreetAddress { get; set; }

    public int? ProjectCity { get; set; }

    public int? ProjectState { get; set; }

    public string? ProjectZipcode { get; set; }

    public string? OwnerFullName { get; set; }

    public string? OwnerContactInformation { get; set; }

    public string? ContractorFullName { get; set; }

    public string? ContractorLicenseNumber { get; set; }

    public string? ContractorContactInformation { get; set; }

    public int? InspectionType { get; set; }

    public string? InspectorFullName { get; set; }

    public string? InspectorId { get; set; }

    public string? InspectionTime { get; set; }

    public int? WeatherConditions { get; set; }

    public string? StructuralComponents { get; set; }

    public string? ElectricalSystems { get; set; }

    public string? PlumbingSystems { get; set; }

    public string? Hvacsystems { get; set; }

    public string? FireSafety { get; set; }

    public string? EnergyEfficiency { get; set; }

    public string? OtherInspectedItems { get; set; }

    public string? InspectionCompliant { get; set; }

    public string? InspectionViolations { get; set; }

    public string? InspectionRequiredCorrections { get; set; }

    public string? InspectionAdditionalComments { get; set; }

    public string? ReInspectionRequired { get; set; }

    public DateTime? ReInspectionDate { get; set; }

    public string? InspectorSignature { get; set; }

    public DateTime? InspectorDate { get; set; }

    public string? ContractorSignature { get; set; }

    public DateTime? ContractorDate { get; set; }

    public string? ReportFiledBy { get; set; }

    public DateTime? DateFiled { get; set; }

    public string? ReportNumber { get; set; }

    public string? WeatherConditionOther { get; set; }

    public int? RemodelingPermitApplicationId { get; set; }

    public string? Designation { get; set; }
}
