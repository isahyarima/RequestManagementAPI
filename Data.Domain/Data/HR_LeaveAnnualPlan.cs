namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_LeaveAnnualPlan
    {
        [Key]
        public Guid LeaveAnnualPlanId { get; set; }

        public Guid? LeaveTypeId { get; set; }

        public Guid? DepartmentId { get; set; }

        public Guid? DepartmentUnitId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(500)]
        public string Instruction { get; set; }

        public string Description { get; set; }

        public DateTime? DateTimeCreated { get; set; }

        public Guid? TenantId { get; set; }
    }
}
