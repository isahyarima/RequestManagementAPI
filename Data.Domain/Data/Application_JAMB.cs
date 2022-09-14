namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_JAMB
    {
        [Key]
        public Guid JambId { get; set; }

        public Guid? StudentId { get; set; }

        [StringLength(50)]
        public string ExamYear { get; set; }

        [StringLength(50)]
        public string CenterNumber { get; set; }

        [StringLength(50)]
        public string CenterName { get; set; }

        [StringLength(50)]
        public string ExamNumber { get; set; }

        public string CenterAddress { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(50)]
        public string ApplicationNumber { get; set; }

        public Guid? FirstSubject { get; set; }

        public int? FirstSubjectScores { get; set; }

        public Guid? SecondSubject { get; set; }

        public int? SecondSubjectScores { get; set; }

        public Guid? ThirdSubject { get; set; }

        public int? ThirdSubjectScores { get; set; }

        public int? UseOfEnglishScores { get; set; }

        public bool? IsCompleted { get; set; }
    }
}
