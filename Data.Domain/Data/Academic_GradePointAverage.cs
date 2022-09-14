namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_GradePointAverage
    {
        [Key]
        public Guid GradePointAverageId { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        public int? RangeFrom { get; set; }

        public int? RangeTo { get; set; }

        public int? Points { get; set; }

        [StringLength(50)]
        public string Grade { get; set; }

        [StringLength(50)]
        public string GradeDefinition { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateTimeCreated { get; set; }
    }
}
