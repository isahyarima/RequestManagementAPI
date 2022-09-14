namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeAward
    {
        [Key]
        public Guid EmployeeAwardId { get; set; }

        public int? BranchId { get; set; }

        [StringLength(200)]
        public string AwardName { get; set; }

        [StringLength(200)]
        public string Gift { get; set; }

        [Column(TypeName = "money")]
        public decimal? CashPrice { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? AwardDate { get; set; }

        public DateTime? DateRegistered { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? EmployeeId { get; set; }
    }
}
