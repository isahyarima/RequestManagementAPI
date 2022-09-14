namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admission_Agent
    {
        [Key]
        public Guid AdmissionAgentId { get; set; }

        [StringLength(200)]
        public string CompanyName { get; set; }

        public string Address { get; set; }

        public int? CountryOfResidentId { get; set; }

        public int? StateId { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        public string EmailAddress { get; set; }

        [StringLength(500)]
        public string AccountName { get; set; }

        [StringLength(20)]
        public string AccountNumber { get; set; }

        [StringLength(200)]
        public string BankName { get; set; }

        [StringLength(50)]
        public string SortCode { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }
    }
}
