namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MIS_StudentAdmission
    {
        [Key]
        public Guid StudentAdmissionId { get; set; }

        public int? AdmissionTypeId { get; set; }

        [StringLength(50)]
        public string AdmissionNumber { get; set; }

        public Guid? AcademicFacultyId { get; set; }

        public Guid? AcademicDepartmentId { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        public Guid? AcademicDegreeProgrammeId { get; set; }

        public DateTime? AdmissionDate { get; set; }

        public int? AdmitedBy { get; set; }

        public Guid? AcademicSessionId { get; set; }

        [StringLength(50)]
        public string Year { get; set; }

        public Guid? StudentId { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
