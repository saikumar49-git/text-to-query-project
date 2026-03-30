using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ContraventionsDetail
{
    public int ContraventionDetailsId { get; set; }

    public int ContraventionId { get; set; }

    public string? State { get; set; }

    public string? Lga { get; set; }

    public string? City { get; set; }

    public string? ViolationType { get; set; }

    public string? ViolationDescription { get; set; }

    public string? RequestedDocs { get; set; }

    public string? EvidenceOfService { get; set; }

    public string? Noticetype { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Createdon { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? District { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? Statusnumber { get; set; }
}
