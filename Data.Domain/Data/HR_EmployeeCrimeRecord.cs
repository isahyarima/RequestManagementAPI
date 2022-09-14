namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeCrimeRecord
    {
        [Key]
        public Guid EmployeeCrimeId { get; set; }

        public Guid? EmployeeId { get; set; }

        public DateTime? CrimeDate { get; set; }

        [StringLength(500)]
        public string Offence { get; set; }

        [StringLength(100)]
        public string LawEnforcementEngency { get; set; }

        [StringLength(200)]
        public string PenaltyEnforced { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
