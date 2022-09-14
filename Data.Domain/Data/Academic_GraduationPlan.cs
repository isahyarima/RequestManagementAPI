namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_GraduationPlan
    {
        [Key]
        public Guid GraduationPlanId { get; set; }

        public Guid? StudentId { get; set; }

        [StringLength(50)]
        public string AdmissionNumber { get; set; }

        public Guid? AcademicSessionId { get; set; }

        public Guid? AcademicSemesterId { get; set; }

        public Guid? AcademicCourseDefinitionId { get; set; }

        public Guid? AcademicLevelId { get; set; }

        [StringLength(50)]
        public string CourseCode { get; set; }

        public int? CreditUnit { get; set; }

        public double? TotalMark { get; set; }

        public int? GradePoint { get; set; }

        [StringLength(50)]
        public string GradeDescription { get; set; }

        public int? StatusId { get; set; }

        public bool? IsRepeating { get; set; }

        public bool? IsPosted { get; set; }

        public bool? IsVerified { get; set; }

        public bool? IsFinalize { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string MacAddress { get; set; }
    }
}
