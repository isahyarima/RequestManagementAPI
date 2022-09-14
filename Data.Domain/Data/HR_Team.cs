namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Team
    {
        [Key]
        public Guid TeamId { get; set; }

        public Guid? DepartmentId { get; set; }

        public int? StatusId { get; set; }

        [StringLength(200)]
        public string TeamName { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
