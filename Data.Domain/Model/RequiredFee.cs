namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequiredFee")]
    public partial class RequiredFee
    {
        public int RequiredFeeId { get; set; }

        public int? RequestTypeId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fee { get; set; }

        public bool? IsVatApply { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
