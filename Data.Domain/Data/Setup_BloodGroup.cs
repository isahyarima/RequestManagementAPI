namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_BloodGroup
    {
        [Key]
        public Guid BloodGroupId { get; set; }

        [StringLength(100)]
        public string BloodGroupName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
