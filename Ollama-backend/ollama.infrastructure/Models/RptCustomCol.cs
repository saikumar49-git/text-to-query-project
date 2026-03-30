using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptCustomCol
{
    public int RecId { get; set; }

    public int ReportId { get; set; }

    public int? ColumnNo { get; set; }

    public int? DashboardId { get; set; }

    public string? ColumnType { get; set; }

    public string? DataType { get; set; }

    public bool? IsHidden { get; set; }

    public string? AppendWith { get; set; }

    public string? Format { get; set; }

    public string? HyperlinkUrl { get; set; }

    public int? Decimals { get; set; }

    public string? ColumnLabel { get; set; }
}
