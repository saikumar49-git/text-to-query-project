using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Holiday
{
    public int HolidayId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public DateOnly? HolidayDate { get; set; }

    public string? Occasion { get; set; }
}
