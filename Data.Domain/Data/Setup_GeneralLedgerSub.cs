namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_GeneralLedgerSub
    {
        [Key]
        public Guid GeneralLedgerSubId { get; set; }

        public Guid? GeneralLedgerId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? ServiceCost { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateRegistered { get; set; }

        public int? OperationId { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(200)]
        public string GeneralLedgerSubName { get; set; }

        public int? FinanceTransactionTypeId { get; set; }
    }
}
