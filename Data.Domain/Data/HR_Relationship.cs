namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Relationship
    {
        [Key]
        public Guid RelationshipId { get; set; }

        [StringLength(200)]
        public string RelationshipName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
