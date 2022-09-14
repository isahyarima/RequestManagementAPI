namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_CourseAssessmentPercentage
    {
        [Key]
        public Guid AcademicCourseAssessmentPercentageId { get; set; }

        public Guid? AcademicGraduationPlanTemplateId { get; set; }

        public int? AssessmentPercent { get; set; }

        public int? ExaminationPercent { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
