namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdmissionCalendarMaster")]
    public partial class AdmissionCalendarMaster
    {
        public Guid AdmissionCalendarMasterId { get; set; }

        public Guid? AcademicSessionId { get; set; }

        [StringLength(50)]
        public string Year { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        public DateTime? AdmissionStartDate { get; set; }

        public DateTime? AdmissionEndDate { get; set; }

        public DateTime? AdmissionPublishingDate { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? IsActive { get; set; }
    }
}
