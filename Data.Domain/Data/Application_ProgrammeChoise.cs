namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_ProgrammeChoise
    {
        [Key]
        public Guid ApplicationProgrammeChoiseId { get; set; }

        public Guid? StudentId { get; set; }

        public Guid? AcademicFacultyId { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        public Guid? AcademicDepartmentId { get; set; }

        public Guid? AcademicCourseId { get; set; }

        public int? ChoisePriorityId { get; set; }

        public Guid? AcademicSessionId { get; set; }

        [StringLength(50)]
        public string Year { get; set; }

        public int? AdmissionTypeId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(50)]
        public string ApplicationNumber { get; set; }

        public bool? IsCompleted { get; set; }

        public int? DirectEntryTypeId { get; set; }

        public int? StatusId { get; set; }

        public bool? IsAttended { get; set; }

        public DateTime? DateModified { get; set; }
    }
}
