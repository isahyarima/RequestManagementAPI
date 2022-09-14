namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeBank
    {
        [Key]
        public Guid BankId { get; set; }

        public Guid? EmployeeId { get; set; }

        [StringLength(200)]
        public string BankName { get; set; }

        [StringLength(200)]
        public string AccountHolder { get; set; }

        [StringLength(200)]
        public string BranchName { get; set; }

        [StringLength(500)]
        public string BankAddress { get; set; }

        [StringLength(20)]
        public string AccountNumber { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}
