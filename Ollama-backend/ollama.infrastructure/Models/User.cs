using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class User
{
    public int UserId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? TitleId { get; set; }

    public int? GenderId { get; set; }

    public int? MaritalStatusId { get; set; }

    public int? StateId { get; set; }

    public int? Lgaid { get; set; }

    public int? CityId { get; set; }

    public int? ApplicantTypeId { get; set; }

    public int? SecurityQuestionId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? SecurityAnswer { get; set; }

    public string? MobileNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? PayerId { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public string? OrganizationName { get; set; }

    public string? Nin { get; set; }

    public bool? IsPayerIdexist { get; set; }

    public string? ForgotPasswordVerificationCode { get; set; }

    public DateOnly? Dob { get; set; }

    public int? DistrictId { get; set; }

    public byte[] PasswordHash { get; set; } = null!;

    public byte[] Salt { get; set; } = null!;

    public string? Bvn { get; set; }

    public bool IsUserZoneBased { get; set; }

    public int? MappedZoneId { get; set; }

    public string? ProfessionalId { get; set; }

    public string? RcNumber { get; set; }

    public string? Industry { get; set; }

    public string? BuildingNo { get; set; }

    public int? BusinessTypeId { get; set; }

    public string? TempOtp { get; set; }

    public DateTime? OtpExpiry { get; set; }

    public int? OtpFailedAttempts { get; set; }

    public DateTime? OtpLockoutUntil { get; set; }

    public string? EpppsAccountId { get; set; }

    public int FailedLoginAttempts { get; set; }

    public DateTime? LockoutEndTime { get; set; }

    public bool IsLocked { get; set; }

    public virtual ApplicantType? ApplicantType { get; set; }

    public virtual City? City { get; set; }

    public virtual District? District { get; set; }

    public virtual ICollection<DistrictOfficer> DistrictOfficers { get; set; } = new List<DistrictOfficer>();

    public virtual Gender? Gender { get; set; }

    public virtual Lga? Lga { get; set; }

    public virtual MaritalStatus? MaritalStatus { get; set; }

    public virtual ICollection<ProfessionalSupervisingConsultant> ProfessionalSupervisingConsultants { get; set; } = new List<ProfessionalSupervisingConsultant>();

    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();

    public virtual ICollection<ReportsUserPermission> ReportsUserPermissions { get; set; } = new List<ReportsUserPermission>();

    public virtual SecurityQuestion? SecurityQuestion { get; set; }

    public virtual State? State { get; set; }

    public virtual UserTitle? Title { get; set; }

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
