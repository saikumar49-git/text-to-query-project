using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WhoIsWho
{
    public int WhoIsWhoId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public int AboutUsId { get; set; }

    public string? WhoIsWhoName { get; set; }

    public string? WhoIsWhoDesignation { get; set; }

    public string? WhoIsWhoImageUrl { get; set; }
}
