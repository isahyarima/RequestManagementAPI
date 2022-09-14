namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeaveRequest")]
    public partial class LeaveRequest
    {
        public int LeaveRequestId { get; set; }

        public int? LeaveTypeId { get; set; }

        public int? StudentId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ResumptionDate { get; set; }

        public string Description { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? termId { get; set; }

        public int? AcademicYearId { get; set; }
    }
}
