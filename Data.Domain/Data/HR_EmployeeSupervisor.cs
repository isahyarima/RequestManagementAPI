namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeSupervisor
    {
        [Key]
        public Guid EmployeeSupervisorId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? SupervisorId { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? StatusId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? TenantId { get; set; }
    }
}
