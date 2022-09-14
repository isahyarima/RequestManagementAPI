namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_SalaryAllowance
    {
        [Key]
        public Guid SalaryAllowanceId { get; set; }

        [StringLength(100)]
        public string AllowanceName { get; set; }

        public Guid? SalaryTemplateId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Allowance { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateRegistered { get; set; }
    }
}
