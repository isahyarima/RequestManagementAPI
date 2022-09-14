namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_Grade
    {
        [Key]
        public Guid AcademicGradeId { get; set; }

        [StringLength(50)]
        public string AcademicGradeName { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? EirectEntryTypeId { get; set; }
    }
}
