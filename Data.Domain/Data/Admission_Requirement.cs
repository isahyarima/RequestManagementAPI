namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admission_Requirement
    {
        [Key]
        public Guid AdmissionRequirementId { get; set; }

        public Guid? AcademicFacultyId { get; set; }

        public Guid? AcademicDepartmentId { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        public Guid AcademicDegreeProgrammeId { get; set; }

        public int? JAMBScores { get; set; }

        public Guid? TenantId { get; set; }

        public string Description { get; set; }
    }
}
