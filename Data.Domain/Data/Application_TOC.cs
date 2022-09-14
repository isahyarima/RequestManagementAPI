namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_TOC
    {
        [Key]
        public Guid TransferId { get; set; }

        public Guid? StudentId { get; set; }

        [StringLength(50)]
        public string YearOfAdmission { get; set; }

        [StringLength(50)]
        public string RegistrationNumber { get; set; }

        [StringLength(500)]
        public string SchoolName { get; set; }

        [StringLength(500)]
        public string SchoolAddress { get; set; }

        [StringLength(500)]
        public string Programme { get; set; }

        public double? CGPA { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(50)]
        public string ApplicationNumber { get; set; }

        [StringLength(50)]
        public string AcademicLevel { get; set; }

        public bool? IsCompleted { get; set; }
    }
}
