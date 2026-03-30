using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Lasbcaconfiguration
{
    public int ConfigurationId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int InspectionDatesGapInDays { get; set; }
}
