namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_DegreeType
    {
        [Key]
        public Guid AcademicDegreeTypeId { get; set; }

        [StringLength(200)]
        public string AcademicDegreeTypeName { get; set; }

        [StringLength(50)]
        public string DegreeTypeCode { get; set; }

        public int? StatusId { get; set; }

        public string Description { get; set; }

        public Guid? TenantId { get; set; }
    }
}
