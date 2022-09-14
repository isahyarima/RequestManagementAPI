namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_LeaveHandOver
    {
        [Key]
        public Guid LeaveHandOverId { get; set; }

        public Guid? LeaveBookId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? StandInEmployeeId { get; set; }

        public DateTime? HandOverDate { get; set; }

        [StringLength(500)]
        public string Task { get; set; }

        [StringLength(50)]
        public string TaskStatus { get; set; }

        public int? HandOverStatusId { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
