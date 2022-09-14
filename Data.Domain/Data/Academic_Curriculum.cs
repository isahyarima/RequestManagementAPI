namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_Curriculum
    {
        [Key]
        public Guid AcademicCurriculumId { get; set; }

        public string Preamble { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? AcademicDegreeProgrammeId { get; set; }

        public string Philosophy { get; set; }

        public string Objective { get; set; }

        public string LeaningOutcome { get; set; }

        public string Regime { get; set; }

        public string Competencies { get; set; }

        public string BehaviouralAttributes { get; set; }
    }
}
