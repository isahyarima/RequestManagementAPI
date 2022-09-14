namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_DocumentUpload
    {
        [Key]
        public Guid DocumentUploadId { get; set; }

        public Guid? DocumentTypeId { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string FileType { get; set; }

        [StringLength(50)]
        public string FileExtention { get; set; }

        [StringLength(500)]
        public string FileLink { get; set; }

        public byte[] FileData { get; set; }

        public Guid? TargetId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? AdmissionRequireDocumentId { get; set; }

        [StringLength(50)]
        public string ApplicationNumber { get; set; }

        public bool? IsCompleted { get; set; }
    }
}
