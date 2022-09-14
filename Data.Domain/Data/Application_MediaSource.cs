namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_MediaSource
    {
        [Key]
        public Guid ApplicationMediaSourceId { get; set; }

        public Guid? MediaSourceId { get; set; }

        public Guid? StudentId { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(50)]
        public string ApplicationNumber { get; set; }

        public bool? IsCompleted { get; set; }

        public Guid? AgentId { get; set; }
    }
}
