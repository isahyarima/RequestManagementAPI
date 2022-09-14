namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeAcademicRecord
    {
        [Key]
        public Guid EmployeeAcademicRecordId { get; set; }

        [StringLength(500)]
        public string SchoolName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EnrolmentDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime GraduationDate { get; set; }

        public Guid? CertificationId { get; set; }

        public Guid EmployeeId { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(2000)]
        public string SchoolAddress { get; set; }
    }
}
