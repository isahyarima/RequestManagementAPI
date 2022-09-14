namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_TeachingMethod
    {
        [Key]
        public Guid AcademicTeachingMethodId { get; set; }

        [StringLength(50)]
        public string AcademicTeachingMethodName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
