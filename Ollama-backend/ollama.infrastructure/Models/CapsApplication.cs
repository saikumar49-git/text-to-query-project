using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CapsApplication
{
    public string? ApplicationId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Email { get; set; }

    public bool IsApplicationRejected { get; set; }

    public int CapsId { get; set; }

    public string? CategoryName { get; set; }

    public string? Cadetails { get; set; }

    public virtual ICollection<CapsFile> CapsFiles { get; set; } = new List<CapsFile>();
}
