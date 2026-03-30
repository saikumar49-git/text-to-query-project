using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcacontraventionPanaltyFee
{
    public int FeeId { get; set; }

    public int ViolatioTypeId { get; set; }

    public string? Fee { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? TypeOfStructure { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public string? RequestServiceName { get; set; }
}
