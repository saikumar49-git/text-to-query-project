using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Contravener
{
    public int ContravenerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? ContraventionDetailsId { get; set; }

    public int? ContraventionId { get; set; }

    public string? EMail { get; set; }

    public string? PhoneNumber { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ContravenerStatusNumber { get; set; }
}
