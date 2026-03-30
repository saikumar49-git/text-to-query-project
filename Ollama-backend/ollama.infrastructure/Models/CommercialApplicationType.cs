using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CommercialApplicationType
{
    public int CommercialApplicationTypeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int AgencyId { get; set; }

    public string? CommercialApplicationTypeName { get; set; }

    public int PlanningPermitApplicationFormTypeId { get; set; }
}
