namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_CourseRegistration
    {
        [Key]
        public Guid CourseRegistrationId { get; set; }

        public Guid? AcademicSemesterId { get; set; }

        public Guid? StudentId { get; set; }

        public Guid? AcademicLevelId { get; set; }

        public Guid? AcademicSessionId { get; set; }

        public Guid? AcademicCourseId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? DateApproved { get; set; }

        public Guid? FinalApprovedBy { get; set; }

        public Guid? ApprovalWorkflowId { get; set; }

        public int? ApprovalStatusId { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
