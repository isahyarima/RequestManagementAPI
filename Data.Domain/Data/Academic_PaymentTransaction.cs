namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_PaymentTransaction
    {
        [Key]
        public Guid PaymentTransactionId { get; set; }

        [StringLength(50)]
        public string PaymentReferenceNumber { get; set; }

        public int? PaymentChannelId { get; set; }

        public int? PaymentTypeId { get; set; }

        public DateTime? PaymentDate { get; set; }

        public Guid? StudentId { get; set; }

        public int? PaymentStatusId { get; set; }

        public string Description { get; set; }

        public Guid? TenantId { get; set; }
    }
}
