namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeExperience
    {
        [Key]
        public Guid EmployeeExperienceId { get; set; }

        [StringLength(100)]
        public string PositionHeld { get; set; }

        [StringLength(200)]
        public string EmployerName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EmploymentDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TerminationDate { get; set; }

        [StringLength(500)]
        public string Contribution { get; set; }

        public Guid EmployeeId { get; set; }

        [StringLength(50)]
        public string ContactNumber { get; set; }

        public Guid? TenantId { get; set; }

        public string Address { get; set; }

        [StringLength(500)]
        public string ReasonForLeaving { get; set; }
    }
}
