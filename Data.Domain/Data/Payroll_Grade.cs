namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payroll_Grade
    {
        [Key]
        public Guid GradeId { get; set; }

        [StringLength(50)]
        public string GradeName { get; set; }

        [StringLength(50)]
        public string GradeCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }
    }
}
