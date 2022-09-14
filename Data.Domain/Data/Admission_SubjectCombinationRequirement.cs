namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admission_SubjectCombinationRequirement
    {
        [Key]
        public Guid SubjectCombinationRequirementId { get; set; }

        public Guid? SetupSubjectId { get; set; }

        public Guid AcademicCourseCategoryId { get; set; }

        public Guid? TenantId { get; set; }

        public int? AdmissionRequirementId { get; set; }
    }
}
