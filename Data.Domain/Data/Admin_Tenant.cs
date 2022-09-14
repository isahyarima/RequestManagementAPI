namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin_Tenant
    {
        [Key]
        public Guid TenantId { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public string Address { get; set; }

        [StringLength(50)]
        public string YearOfEstablishment { get; set; }

        public int? StateId { get; set; }

        public int? LocalGovtId { get; set; }

        [StringLength(20)]
        public string ContactNumber1 { get; set; }

        [StringLength(200)]
        public string Email1 { get; set; }

        [StringLength(200)]
        public string ContactPerson { get; set; }

        [StringLength(20)]
        public string ContactNumber2 { get; set; }

        [StringLength(200)]
        public string WebAddress { get; set; }

        [StringLength(500)]
        public string CompanyMotto { get; set; }

        [StringLength(500)]
        public string ReceiptFarewellInfor { get; set; }

        [StringLength(500)]
        public string SalesTerm1 { get; set; }

        [StringLength(500)]
        public string SalesTerm2 { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string OfficeNumber { get; set; }

        [StringLength(50)]
        public string ContactPersonPhone { get; set; }

        [StringLength(50)]
        public string ContactPersonEmail { get; set; }

        [StringLength(200)]
        public string Email2 { get; set; }
    }
}
