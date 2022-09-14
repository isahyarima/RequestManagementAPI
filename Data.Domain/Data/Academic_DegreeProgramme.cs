namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_DegreeProgramme
    {
        [Key]
        public Guid AcademicDegreeProgrammeId { get; set; }

        public Guid? AcademicFacultyId { get; set; }

        public Guid? AcademicDepartmentId { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        [StringLength(500)]
        public string AcademicDegreeProgrammeName { get; set; }

        [StringLength(50)]
        public string DegreeProgrammeCode { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }
    }
}
