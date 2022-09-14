namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_HealthInsurancePlan
    {
        [Key]
        public Guid HealthInsurancePlanId { get; set; }

        public Guid? GradeId { get; set; }

        public Guid? GradeLevelId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rate { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }
    }
}
