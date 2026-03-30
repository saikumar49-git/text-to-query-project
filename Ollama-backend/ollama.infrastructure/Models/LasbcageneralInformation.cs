using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcageneralInformation
{
    public int GeneralInformationId { get; set; }

    public int? RequestServiceId { get; set; }

    public int? UserId { get; set; }

    public string? PermitNumber { get; set; }

    public int? TypeOfPermit { get; set; }

    public int? ProposedUse { get; set; }

    public int? BuildingType { get; set; }

    public int? NoOfBuildingsOrStructure { get; set; }

    public int? NoOfUnits { get; set; }

    public int? NoOfFloorsPerBuilding { get; set; }

    public string? ParcelNumber { get; set; }

    public string? Zoning { get; set; }

    public string? LotSize { get; set; }

    public string? AplicantFirstName { get; set; }

    public string? AplicantLastName { get; set; }

    public string? AplicantMiddleName { get; set; }

    public string? OwnerFirstName { get; set; }

    public string? OwnerLastName { get; set; }

    public string? OwnerMiddleName { get; set; }

    public int ApplicantAddressId { get; set; }

    public int PropertyAddressId { get; set; }

    public string ApplicantPhoneNumber { get; set; } = null!;

    public string? ApplicantEmail { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? AuthorizationCommenceId { get; set; }

    public string? PolicyNumber { get; set; }
}
