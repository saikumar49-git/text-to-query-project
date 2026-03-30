using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcacontraventionV2
{
    public int ContraventionId { get; set; }

    public int? AuthorizationCommenceId { get; set; }

    public int? RequestServiceId { get; set; }

    public int? AddressId { get; set; }

    public string? ApplicationNumber { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? Offences { get; set; }

    public string? RequestedDocs { get; set; }

    public string? TypeOfConstruction { get; set; }

    public decimal? Penalty { get; set; }

    public bool? PaymentStatus { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? IsIndividual { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? UserId { get; set; }

    public string? Developer { get; set; }

    public bool? IsDistressed { get; set; }
}
