namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_ResultPosting
    {
        [Key]
        public Guid AcademicResultPostingId { get; set; }

        public Guid? StudentId { get; set; }

        [StringLength(50)]
        public string AdmissionNumber { get; set; }

        public Guid? AcademicSessionId { get; set; }

        public Guid? AcademicSemesterId { get; set; }

        public Guid? AcademicCourseDefinitionId { get; set; }

        public Guid? AcademicLevelId { get; set; }

        [StringLength(50)]
        public string CourseCode { get; set; }

        public Guid? AcademicCourseAssessmentTypeSettingId { get; set; }

        public bool? IsRegistered { get; set; }

        public DateTime? DateRegistered { get; set; }

        public Guid? RegistedBy { get; set; }

        public double? Mark { get; set; }

        public int? CreditUnit { get; set; }

        [StringLength(50)]
        public string Grade { get; set; }

        public int? Points { get; set; }

        public int? GradePoints { get; set; }

        public bool? IsPosted { get; set; }

        public DateTime? DatePosted { get; set; }

        public Guid? PostedBy { get; set; }

        public bool? IsFinalize { get; set; }

        public DateTime? DateFinalized { get; set; }

        public Guid? FinalizedBy { get; set; }

        public bool? IsPublished { get; set; }

        public DateTime? DatePublished { get; set; }

        public Guid? PublishedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string MacAddress { get; set; }
    }
}
