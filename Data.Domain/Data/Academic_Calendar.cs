namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Academic_Calendar
    {
        [Key]
        public Guid AcademicCalendarId { get; set; }

        [StringLength(50)]
        public string AcademicCalendarName { get; set; }

        public Guid? AcademicSessionId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? StatusId { get; set; }

        public Guid? TenantId { get; set; }
    }
}
