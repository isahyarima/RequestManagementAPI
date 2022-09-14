namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestType")]
    public partial class RequestType
    {
        public int RequestTypeId { get; set; }

        [StringLength(50)]
        public string RequestTypeName { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
