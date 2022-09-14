namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeePassport
    {
        [Key]
        public Guid EmployeePassportId { get; set; }

        public int? DocumentTypeId { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string FileType { get; set; }

        [StringLength(50)]
        public string FileExtention { get; set; }

        [StringLength(500)]
        public string FileLink { get; set; }

        public byte[] FileData { get; set; }

        public int? TargetId { get; set; }

        public Guid? RoleId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
