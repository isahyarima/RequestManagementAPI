namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_LeaveDays
    {
        [Key]
        public Guid LeaveDaysId { get; set; }

        public Guid? LeaveTypeId { get; set; }

        public int? Days { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? LastDateUpdated { get; set; }
    }
}
