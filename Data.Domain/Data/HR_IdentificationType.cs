namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_IdentificationType
    {
        [Key]
        public Guid IdentificationTypeId { get; set; }

        [StringLength(50)]
        public string IdentificationTypeName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
