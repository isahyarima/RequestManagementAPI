namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_CoursePriority
    {
        [Key]
        public Guid CoursePriorityd { get; set; }

        [StringLength(50)]
        public string PriorityName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
