using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Lasbcacontravener
{
    public int ContravenerId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public int? ContraventionId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? UserId { get; set; }

    public string? TypeOfStructure { get; set; }
}
