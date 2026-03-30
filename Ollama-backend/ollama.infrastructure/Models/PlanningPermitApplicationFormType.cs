using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitApplicationFormType
{
    public int PlanningPermitApplicationFormTypeId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? FormType { get; set; }

    public bool? IsVisibleForRestamping { get; set; }

    public virtual ICollection<ElectricalVettingFormDetail> ElectricalVettingFormDetails { get; set; } = new List<ElectricalVettingFormDetail>();

    public virtual ICollection<FencingStructuralVettingFormDetail> FencingStructuralVettingFormDetails { get; set; } = new List<FencingStructuralVettingFormDetail>();

    public virtual ICollection<LandType> LandTypes { get; set; } = new List<LandType>();

    public virtual ICollection<OwnershipChangeAssessmentFeeCalculation> OwnershipChangeAssessmentFeeCalculations { get; set; } = new List<OwnershipChangeAssessmentFeeCalculation>();

    public virtual ICollection<PhysicalPlanningSiteInspectionReport> PhysicalPlanningSiteInspectionReports { get; set; } = new List<PhysicalPlanningSiteInspectionReport>();

    public virtual ICollection<PlanningPermitApplicationDetail> PlanningPermitApplicationDetails { get; set; } = new List<PlanningPermitApplicationDetail>();

    public virtual ICollection<PlanningPermitArchitecturalVettingFormDetail> PlanningPermitArchitecturalVettingFormDetails { get; set; } = new List<PlanningPermitArchitecturalVettingFormDetail>();

    public virtual ICollection<PlanningPermitAssessmentFeeCalculation> PlanningPermitAssessmentFeeCalculations { get; set; } = new List<PlanningPermitAssessmentFeeCalculation>();

    public virtual ICollection<PpbuildingTypeFormTypeMapping> PpbuildingTypeFormTypeMappings { get; set; } = new List<PpbuildingTypeFormTypeMapping>();

    public virtual ICollection<RemodelingElectricalVettingFormDetail> RemodelingElectricalVettingFormDetails { get; set; } = new List<RemodelingElectricalVettingFormDetail>();

    public virtual ICollection<RemodelingPermitArchitecturalVettingFormDetail> RemodelingPermitArchitecturalVettingFormDetails { get; set; } = new List<RemodelingPermitArchitecturalVettingFormDetail>();

    public virtual ICollection<RemodelingPermitAssessmentFeeCalculation> RemodelingPermitAssessmentFeeCalculations { get; set; } = new List<RemodelingPermitAssessmentFeeCalculation>();

    public virtual ICollection<RemodelingStructuralVettingFormDetail> RemodelingStructuralVettingFormDetails { get; set; } = new List<RemodelingStructuralVettingFormDetail>();

    public virtual ICollection<RenovationPermitApplicationDetail> RenovationPermitApplicationDetails { get; set; } = new List<RenovationPermitApplicationDetail>();

    public virtual ICollection<SpecialApplicationType> SpecialApplicationTypes { get; set; } = new List<SpecialApplicationType>();

    public virtual ICollection<StructuralVettingFormDetail> StructuralVettingFormDetails { get; set; } = new List<StructuralVettingFormDetail>();

    public virtual ICollection<UtfpassessmentFeeCalculation> UtfpassessmentFeeCalculations { get; set; } = new List<UtfpassessmentFeeCalculation>();
}
