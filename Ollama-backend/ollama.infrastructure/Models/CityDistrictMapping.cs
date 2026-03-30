using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CityDistrictMapping
{
    public int CityDistrictId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? CityId { get; set; }

    public int? DistrictId { get; set; }
}
