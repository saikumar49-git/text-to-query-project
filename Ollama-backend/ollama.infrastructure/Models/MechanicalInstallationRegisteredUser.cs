using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MechanicalInstallationRegisteredUser
{
    public int MifruserId { get; set; }

    public int? MicformId { get; set; }

    public bool? IsAgree { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? RegistrationNumer { get; set; }

    public string? RegisterDate { get; set; }

    public string? SignatureFileName { get; set; }

    public string? SealFileName { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
