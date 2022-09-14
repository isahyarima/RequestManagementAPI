namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_Department
    {
        [Key]
        public Guid AcademicDepartmentId { get; set; }

        public Guid? AcademicFacultyId { get; set; }

        [StringLength(500)]
        public string AcademicDepartmentName { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }
    }
}
