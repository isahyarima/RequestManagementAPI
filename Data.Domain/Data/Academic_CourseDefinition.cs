namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_CourseDefinition
    {
        [Key]
        public Guid AcademicCourseDefinitionId { get; set; }

        public Guid? AcademicFacultyId { get; set; }

        public Guid? AcademicDepartmentId { get; set; }

        public Guid? AcademicLevelId { get; set; }

        [StringLength(50)]
        public string CourseCode { get; set; }

        [StringLength(500)]
        public string CourseName { get; set; }

        public int? CourseUnit { get; set; }

        public string Description { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        public Guid? AcademicDegreeProgrammeId { get; set; }

        public Guid? AcademicTeachingMethodId { get; set; }
    }
}
