using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class OwnershipChangeApplicationFormDetail
{
    public int OwnershipChangeApplicationFormDetailId { get; set; }

    public bool IsActive { get; set; }

    public int OwnershipChangeApplicationId { get; set; }

    public int? DistrictId { get; set; }

    public int? StateId { get; set; }

    public int? LgaId { get; set; }

    public int? CityId { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public int? TitleId { get; set; }

    public string? TitleOwnerCorporateName { get; set; }

    public virtual City? City { get; set; }

    public virtual District? District { get; set; }

    public virtual Lga? Lga { get; set; }

    public virtual OwnershipChangeApplication OwnershipChangeApplication { get; set; } = null!;

    public virtual State? State { get; set; }
}
