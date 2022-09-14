namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin_LoginActivity
    {
        [Key]
        public Guid LoginActivityId { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public bool IsLocked { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastLoginDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? LoginUserTypeId { get; set; }

        [StringLength(200)]
        public string UserName { get; set; }

        public Guid? RoleId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? TenantId { get; set; }
    }
}
