namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestCategory")]
    public partial class RequestCategory
    {
        public int RequestCategoryId { get; set; }

        public int? RequestTypeId { get; set; }

        [StringLength(50)]
        public string RequestCategoryName { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
