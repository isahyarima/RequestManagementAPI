namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin_Role
    {
        [Key]
        public Guid RoleId { get; set; }

        [StringLength(50)]
        public string RoleName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
