using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RoleAgencyMapping
{
    public int RoleAgencyId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RoleId { get; set; }

    public int? AgencyId { get; set; }
}
