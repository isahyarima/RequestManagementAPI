namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_LeaveType
    {
        [Key]
        public Guid LeaveTypeId { get; set; }

        [StringLength(50)]
        public string LeaveTypeName { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? RoleId { get; set; }

        public int? AppoveDays { get; set; }

        public int? BranchId { get; set; }
    }
}
