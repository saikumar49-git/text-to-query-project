using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RptTenantFilterConfig
{
    public int ConfigId { get; set; }

    public int? TenantId { get; set; }

    public int? ReportId { get; set; }

    public int? FilterId { get; set; }

    public string? DispalyName { get; set; }

    public int? Position { get; set; }

    public bool? IsPrimaryFilter { get; set; }

    public string? DefaultValue { get; set; }

    public int? MaxLength { get; set; }

    public string? MinDate { get; set; }

    public string? MaxDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? ColumnWidth { get; set; }
}
