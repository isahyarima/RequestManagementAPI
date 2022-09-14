namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestDescription")]
    public partial class RequestDescription
    {
        public int RequestDescriptionId { get; set; }

        public string Description { get; set; }

        public int? RequestTypeId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
