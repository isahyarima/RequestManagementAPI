namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_CourseSchedule
    {
        [Key]
        public Guid AcademicCourseScheduleId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? AcademicGraduationPlanTemplateId { get; set; }

        public Guid? AcademicSessionId { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
