namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_Session
    {
        [Key]
        public Guid AcademicSessionId { get; set; }

        [StringLength(50)]
        public string AcademicSessionName { get; set; }

        public bool? IsActive { get; set; }

        public Guid? TenantId { get; set; }
    }
}
