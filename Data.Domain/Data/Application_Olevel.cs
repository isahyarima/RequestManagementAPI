namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_Olevel
    {
        [Key]
        public Guid OlevelId { get; set; }

        [StringLength(50)]
        public string ExamYear { get; set; }

        [StringLength(50)]
        public string ExamBatch { get; set; }

        [StringLength(50)]
        public string CenterNumber { get; set; }

        [StringLength(50)]
        public string ExamNumber { get; set; }

        public Guid? SetupSubjectId { get; set; }

        public Guid? GradeId { get; set; }

        [StringLength(50)]
        public string CenterName { get; set; }

        public Guid? StudentId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }

        public int? NumberOfSittings { get; set; }

        public bool? IsInternationalStudent { get; set; }

        [StringLength(50)]
        public string ApplicationNumber { get; set; }

        [StringLength(500)]
        public string CenterAddress { get; set; }

        public bool? IsCompleted { get; set; }
    }
}
