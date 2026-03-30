using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class NewsAndUpdate
{
    public int NewsAndUpdatesId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string NewsAndUpdatesTitle { get; set; } = null!;

    public string NewsAndUpdatesDescription { get; set; } = null!;

    public int NewsAndUpdatesRank { get; set; }

    public bool IsArchive { get; set; }
}
