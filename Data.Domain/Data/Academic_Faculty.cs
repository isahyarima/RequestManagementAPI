namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_Faculty
    {
        [Key]
        public Guid AcademicFacultyId { get; set; }

        [Required]
        [StringLength(500)]
        public string AcademicFacultyName { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }
    }
}
