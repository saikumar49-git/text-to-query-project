using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcacertificateOfFitnessAndBuilding
{
    public int FieldId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? RequestServiceId { get; set; }

    public int? UserId { get; set; }

    public string? PermitNumber { get; set; }

    public int? TypeOfPermit { get; set; }

    public string? FullName { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? PropertyOwnerName { get; set; }

    public string? PropertyAddress { get; set; }

    public int? Pin { get; set; }

    public string? Zoining { get; set; }

    public string? PropertyType { get; set; }

    public string? PurposeForRequest { get; set; }

    public string? BuildingArea { get; set; }

    public int? NoOfFloors { get; set; }

    public int? NoOfUnits { get; set; }

    public string? BuildingType { get; set; }

    public bool? BuildingCode { get; set; }

    public string? CodeReason { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public bool? FireSafety { get; set; }

    public string? SafetyReason { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ApplicationId { get; set; }
}
