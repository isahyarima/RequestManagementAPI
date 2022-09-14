namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_Declaration
    {
        [Key]
        public Guid ApplicationDeclarationId { get; set; }

        [StringLength(50)]
        public string ApplicationNumber { get; set; }

        public Guid? StudentId { get; set; }

        public string Declaration { get; set; }

        public bool? IsSigned { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? IsCompleted { get; set; }
    }
}
