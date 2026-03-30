using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ReportsCategory
{
    public int CategoryId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CategoryName { get; set; }

    public int? AgencyId { get; set; }

    public virtual Agency? Agency { get; set; }

    public virtual ICollection<SubReport> SubReports { get; set; } = new List<SubReport>();
}
