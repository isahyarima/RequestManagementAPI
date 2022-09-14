namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestFee")]
    public partial class RequestFee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequestFeeId { get; set; }

        public int? RequestTypeId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fee { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? IsApproved { get; set; }

        public int? termId { get; set; }

        public int? AcademicYearId { get; set; }
    }
}
