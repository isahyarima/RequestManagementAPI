namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_InsuranceCompany
    {
        [Key]
        public Guid InsuranceCompanyId { get; set; }

        [StringLength(100)]
        public string InsuranceCompanyName { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(50)]
        public string ContactNumber { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
