using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RmdrequestForm
{
    public int RmdrequestFormId { get; set; }

    public int? Rmdid { get; set; }

    public bool? IsActive { get; set; }

    public int? SubmittedBy { get; set; }

    public int? ApplicantTitleOwnerClassId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? OrganizationName { get; set; }

    public int? DistrictId { get; set; }

    public int? CityId { get; set; }

    public int? Lgaid { get; set; }

    public int? StateId { get; set; }

    public string? StreetAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? PurposeOfRequest { get; set; }

    public string? Rmdtitle { get; set; }

    public string? ChaptersRequired { get; set; }

    public int? PreferredFormat { get; set; }

    public int? PaymentMethod { get; set; }

    public string? PaymentTypeText { get; set; }

    public bool? TermsAndConditions { get; set; }

    public string? Signature { get; set; }

    public DateTime? DateOfSubmission { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Rmdapplication? Rmd { get; set; }
}
