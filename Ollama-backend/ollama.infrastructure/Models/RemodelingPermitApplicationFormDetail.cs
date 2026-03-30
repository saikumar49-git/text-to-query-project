using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitApplicationFormDetail
{
    public int RemodelingPermitApplicationFormDetailId { get; set; }

    public int? RemodelingPermitApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ApplicantFirstName { get; set; }

    public string? ApplicantMiddleName { get; set; }

    public string? ApplicantLastName { get; set; }

    public string? ApplicantAddress { get; set; }

    public int? ApplicantState { get; set; }

    public int? ApplicantLga { get; set; }

    public int? ApplicantCity { get; set; }

    public string? ApplicantPhoneNumber { get; set; }

    public string? ApplicantEmail { get; set; }

    public string? PropertyOwnerFirstName { get; set; }

    public string? PropertyOwnerMiddleName { get; set; }

    public string? PropertyOwnerLastName { get; set; }

    public string? PropertyOwnerAddress { get; set; }

    public int? PropertyOwnerState { get; set; }

    public int? PropertyOwnerLga { get; set; }

    public int? PropertyOwnerCity { get; set; }

    public string? ParcelNumber { get; set; }

    public int? ZoningDistrict { get; set; }

    public string? PropertyCurrentUse { get; set; }

    public string? RemodelingType { get; set; }

    public string? WorkDetailedDescription { get; set; }

    public string? ContractorName { get; set; }

    public string? ContractorLicenseNumber { get; set; }

    public string? ContractorPhoneNumber { get; set; }

    public string? ContractorEmail { get; set; }

    public string? TotalEstimatedCost { get; set; }

    public string? ApplicantSignature { get; set; }

    public DateTime? ApplicantDate { get; set; }

    public string? ApplicationNumber { get; set; }

    public DateTime? DateReceived { get; set; }

    public string? ReviewedBy { get; set; }

    public string? PermitApproved { get; set; }

    public string? ApprovalConditions { get; set; }

    public string? BuildingDepartmentAddress { get; set; }

    public int? BuildingDepartmentState { get; set; }

    public int? BuildingDepartmentLga { get; set; }

    public int? BuildingDepartmentCity { get; set; }

    public string? BuildingDepartmentPhoneNumber { get; set; }

    public string? BuildingDepartmentEmail { get; set; }

    public string? BuildingDepartmentWebsiteUrl { get; set; }

    public int? ServiceModeAmountId { get; set; }

    public int? ServiceModeId { get; set; }

    public int? RemodelingPermitApplicationStatusId { get; set; }

    public int? MaxNumberOfFloors { get; set; }

    public string? PermitNumber { get; set; }

    public int? TitleOwnerClassid { get; set; }

    public int? ApplicantTitleid { get; set; }

    public string? ApplicantCorporateName { get; set; }

    public int? ProposedUseOfDevelopmentid { get; set; }

    public string? BuildingType { get; set; }

    public string? OtherBuildingType { get; set; }
}
