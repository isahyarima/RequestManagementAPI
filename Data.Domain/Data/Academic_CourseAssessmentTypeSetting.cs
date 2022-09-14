namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_CourseAssessmentTypeSetting
    {
        [Key]
        public Guid AcademicCourseAssessmentTypeSettingId { get; set; }

        public Guid? AcademicGraduationPlanTemplateId { get; set; }

        public Guid? AcademicAssessmentToolId { get; set; }

        public int? Mark { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? TenantId { get; set; }
    }
}
