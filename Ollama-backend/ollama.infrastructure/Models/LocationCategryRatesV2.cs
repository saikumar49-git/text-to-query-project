using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LocationCategryRatesV2
{
    public int LocationCategoryRatesId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public decimal? RegistrationFee { get; set; }

    public decimal? LayoutFee { get; set; }

    public decimal? SpecialApplicationLayoutFee { get; set; }

    public int? CategoryId { get; set; }
}
