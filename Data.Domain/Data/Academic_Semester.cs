namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_Semester
    {
        [Key]
        public Guid AcademicSemesterId { get; set; }

        [StringLength(50)]
        public string AcademicSemesterName { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }
    }
}
