namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_GraduationPlanTemplate
    {
        [Key]
        public Guid AcademicGraduationPlanTemplateId { get; set; }

        public Guid? AcademicCourseDefinitionId { get; set; }

        public Guid? AcademicFacultyId { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        public Guid? AcademicDegreeProgrammeId { get; set; }

        public Guid? AcademicDepartmentId { get; set; }

        public Guid? AcademicLevelId { get; set; }

        public Guid? AcademicCourseCategoryId { get; set; }

        public Guid? AcademicSemesterId { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? CreatedBy { get; set; }
    }
}
