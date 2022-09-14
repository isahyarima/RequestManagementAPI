namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AcademicYearCalendarMaster")]
    public partial class AcademicYearCalendarMaster
    {
        public Guid AcademicYearCalendarMasterId { get; set; }

        public Guid? AcademicSessionId { get; set; }

        [StringLength(50)]
        public string Year { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid? TenantId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
