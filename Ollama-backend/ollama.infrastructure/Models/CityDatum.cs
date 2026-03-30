using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CityDatum
{
    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public string? DistrictName { get; set; }
}
