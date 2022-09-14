namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AcademicActivitiesCalendarMaster")]
    public partial class AcademicActivitiesCalendarMaster
    {
        public Guid AcademicActivitiesCalendarMasterId { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        public Guid? AcademicSessionId { get; set; }

        public Guid? AcademicActivityTypeId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? IsActive { get; set; }
    }
}
