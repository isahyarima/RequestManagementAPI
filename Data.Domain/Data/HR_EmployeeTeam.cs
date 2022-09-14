namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeTeam
    {
        [Key]
        public Guid EmployeeTeamId { get; set; }

        public Guid? DepartmentId { get; set; }

        public Guid? TeamId { get; set; }

        public Guid? EmployeeId { get; set; }

        public int? StatusId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }
    }
}
