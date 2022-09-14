namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AcademicActiveSemesterMaster")]
    public partial class AcademicActiveSemesterMaster
    {
        public Guid AcademicActiveSemesterMasterId { get; set; }

        public Guid? AcademicSessionId { get; set; }

        public Guid? AcademicSemesterId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }
    }
}
