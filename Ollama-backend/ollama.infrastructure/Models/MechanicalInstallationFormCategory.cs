using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MechanicalInstallationFormCategory
{
    public int MifcategoryId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CategoryName { get; set; }

    public string? FormNumber { get; set; }
}
