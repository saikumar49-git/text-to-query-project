using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SearchProcessApplication
{
    public int SearchProcessApplicationId { get; set; }

    public int? ArchivalDocumentTypesId { get; set; }

    public string? NameOfDocument { get; set; }

    public string? ApprovedNumber { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public int? RequestServiceId { get; set; }

    public string? OtherDocumentTypeText { get; set; }

    public int? DistrictId { get; set; }

    public string? OrganizationName { get; set; }

    public int? DocumentArchivalId { get; set; }

    public virtual ArchivalDocumentType? ArchivalDocumentTypes { get; set; }

    public virtual ICollection<SearchProcessPayment> SearchProcessPayments { get; set; } = new List<SearchProcessPayment>();
}
