namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExamRequest")]
    public partial class ExamRequest
    {
        public int ExamRequestId { get; set; }

        public int? StudentId { get; set; }

        public int? BatchId { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? IsApproved { get; set; }

        public int? termId { get; set; }

        public int? AcademicYearId { get; set; }
    }
}
