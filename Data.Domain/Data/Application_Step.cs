namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_Step
    {
        [Key]
        public Guid ApplicationStepId { get; set; }

        [StringLength(50)]
        public string StepName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
