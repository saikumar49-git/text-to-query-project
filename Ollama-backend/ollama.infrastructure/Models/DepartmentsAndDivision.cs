using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DepartmentsAndDivision
{
    public int DepartmentsAndDivisionsId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public int? MinistryId { get; set; }

    public string? DepartmentName { get; set; }

    public string? DepartmentDescription { get; set; }

    public string? DirectorName { get; set; }

    public string? DirectorResponsibilities { get; set; }

    public string? DirectorContactInformation { get; set; }

    public string? DirectorImageUrl { get; set; }
}
