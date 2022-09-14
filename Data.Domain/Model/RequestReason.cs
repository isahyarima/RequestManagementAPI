namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestReason")]
    public partial class RequestReason
    {
        public int RequestReasonId { get; set; }

        public string RequestReasonName { get; set; }

        public int? RequestTypeId { get; set; }
    }
}
