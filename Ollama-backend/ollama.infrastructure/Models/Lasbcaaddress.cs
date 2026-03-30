using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Lasbcaaddress
{
    public int AddressId { get; set; }

    public string? Address { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public int? District { get; set; }

    public int? LgaorLcda { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
