using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Contravention
{
    public int ContraventionId { get; set; }

    public string? ContraventionRefNum { get; set; }

    public int ViolationTypeId { get; set; }

    public string? ProposedPenalty { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? PaymentStatus { get; set; }
}
