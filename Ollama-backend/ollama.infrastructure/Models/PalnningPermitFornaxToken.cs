using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PalnningPermitFornaxToken
{
    public int PalnningPermitFornaxTokenId { get; set; }

    public bool? IsActive { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModiFiedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Token { get; set; }
}
