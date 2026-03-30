using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptFavorite
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ReportId { get; set; }

    public DateTime? Date { get; set; }
}
