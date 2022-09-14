namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_SalaryDeduction
    {
        [Key]
        public Guid SalaryDeductionId { get; set; }

        [StringLength(100)]
        public string SalaryDeductionName { get; set; }

        public Guid? SalaryTemplateId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Deduction { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateRegistered { get; set; }
    }
}
