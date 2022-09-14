namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_DepartmentUnit
    {
        [Key]
        public Guid DepartmentUnitId { get; set; }

        public Guid? DepartmentId { get; set; }

        [StringLength(200)]
        public string DepartmentBranchName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
