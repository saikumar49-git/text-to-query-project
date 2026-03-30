using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitApplication
{
    public int PlanningPermitApplicationId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ApplicationNumber { get; set; }

    public int AgencyId { get; set; }

    public int RequestServiceId { get; set; }

    public string? PermitNumber { get; set; }

    public DateTime? PermitNumberCreatedOn { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual ICollection<ElectricalVettingFormDetail> ElectricalVettingFormDetails { get; set; } = new List<ElectricalVettingFormDetail>();

    public virtual ICollection<PalnningPermitFornaxDetail> PalnningPermitFornaxDetails { get; set; } = new List<PalnningPermitFornaxDetail>();

    public virtual ICollection<PalnningPermitFornaxProjectDetail> PalnningPermitFornaxProjectDetails { get; set; } = new List<PalnningPermitFornaxProjectDetail>();

    public virtual ICollection<PlanningPermitApplicationDetail> PlanningPermitApplicationDetails { get; set; } = new List<PlanningPermitApplicationDetail>();

    public virtual ICollection<PlanningPermitApplicationFormDetail> PlanningPermitApplicationFormDetails { get; set; } = new List<PlanningPermitApplicationFormDetail>();

    public virtual ICollection<PlanningPermitArchitectDetail> PlanningPermitArchitectDetails { get; set; } = new List<PlanningPermitArchitectDetail>();

    public virtual ICollection<PlanningPermitArchitecturalVettingFormDetail> PlanningPermitArchitecturalVettingFormDetails { get; set; } = new List<PlanningPermitArchitecturalVettingFormDetail>();

    public virtual ICollection<PlanningPermitAssessmentFeeCalculation> PlanningPermitAssessmentFeeCalculations { get; set; } = new List<PlanningPermitAssessmentFeeCalculation>();

    public virtual ICollection<PlanningPermitLirsdecisionDetail> PlanningPermitLirsdecisionDetails { get; set; } = new List<PlanningPermitLirsdecisionDetail>();

    public virtual ICollection<PlanningPermitPayment> PlanningPermitPayments { get; set; } = new List<PlanningPermitPayment>();

    public virtual ICollection<PlanningPermitSupervisorDetail> PlanningPermitSupervisorDetails { get; set; } = new List<PlanningPermitSupervisorDetail>();

    public virtual RequestService RequestService { get; set; } = null!;

    public virtual ICollection<StructuralVettingFormDetail> StructuralVettingFormDetails { get; set; } = new List<StructuralVettingFormDetail>();
}
