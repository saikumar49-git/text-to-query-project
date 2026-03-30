using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ProfessionalReference
{
    public int ProfessionalReferenceId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public string? Category { get; set; }

    public string? Professionalrole { get; set; }

    public string? FirstName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }
}
