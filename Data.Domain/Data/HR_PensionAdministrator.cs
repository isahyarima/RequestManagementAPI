namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_PensionAdministrator
    {
        [Key]
        public Guid PensionAdministratorId { get; set; }

        public Guid? EmployeeId { get; set; }

        [StringLength(50)]
        public string PensionNumber { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
