namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_OLevelSubject
    {
        [Key]
        public Guid SetupSubjectId { get; set; }

        [StringLength(200)]
        public string SubjectName { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }
    }
}
