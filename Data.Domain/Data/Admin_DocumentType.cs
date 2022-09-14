namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin_DocumentType
    {
        [Key]
        public Guid DocumentTypeId { get; set; }

        [StringLength(50)]
        public string DocumentTypeName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
