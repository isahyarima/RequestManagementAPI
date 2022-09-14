namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_MediaSource
    {
        [Key]
        public Guid MediaSourceId { get; set; }

        [StringLength(100)]
        public string MediaSourceName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
