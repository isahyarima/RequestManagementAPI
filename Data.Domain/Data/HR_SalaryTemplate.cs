namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_SalaryTemplate
    {
        [Key]
        public Guid SalaryTemplateId { get; set; }

        [StringLength(50)]
        public string SalaryTemplateName { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(50)]
        public string SalaryGrade { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasicSalary { get; set; }

        public DateTime? DateRegistered { get; set; }

        [Column(TypeName = "money")]
        public decimal? Overtime { get; set; }
    }
}
