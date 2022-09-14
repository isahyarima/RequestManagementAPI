namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeHealthInsurance
    {
        [Key]
        public Guid EmployeeHealthInsuranceId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? HealthInsurancePlanId { get; set; }

        public DateTime? DateRegistered { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntill { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
