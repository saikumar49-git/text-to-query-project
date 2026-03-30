using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcareqestedDocument
{
    public int RequestDocsId { get; set; }

    public string? ApplicationId { get; set; }

    public int? RequestServiceId { get; set; }

    public string? RequestedDocs { get; set; }

    public int? RequestedBy { get; set; }

    public int? SubmittedBy { get; set; }

    public bool? Status { get; set; }

    public string? StatusMessage { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
