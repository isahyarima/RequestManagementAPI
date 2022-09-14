namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_SalaryAdvance
    {
        [Key]
        public Guid SalaryAdvanceId { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? EmployeeId { get; set; }

        public DateTime? DeductionMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateRegistered { get; set; }

        public int? ApprovalStatusId { get; set; }
    }
}
