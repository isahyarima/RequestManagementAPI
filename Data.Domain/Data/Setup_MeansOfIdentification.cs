namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_MeansOfIdentification
    {
        [Key]
        public Guid MeansOfIdentificationId { get; set; }

        [StringLength(50)]
        public string MeansOfIdentificationName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
