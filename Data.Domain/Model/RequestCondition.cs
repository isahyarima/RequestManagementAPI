namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestCondition")]
    public partial class RequestCondition
    {
        public int RequestConditionId { get; set; }

        public string RequestConditionName { get; set; }

        public int? RequestTypeId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
