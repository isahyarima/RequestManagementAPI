namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_PaymentType
    {
        [Key]
        public Guid PaymentTypeId { get; set; }

        [StringLength(50)]
        public string PaymentTypeName { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
