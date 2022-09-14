namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeFitness
    {
        [Key]
        public Guid EmployeeFitnessId { get; set; }

        public Guid? EmployeeId { get; set; }

        public int? BloodGroupId { get; set; }

        [StringLength(50)]
        public string Genotype { get; set; }

        [StringLength(50)]
        public string Height { get; set; }

        [StringLength(50)]
        public string Weight { get; set; }

        public bool? IsPhysicalDisability { get; set; }

        public string PhysicalDisability { get; set; }

        public bool? IsHavingChronicDisease { get; set; }

        public string HavingChronicDisease { get; set; }

        public bool? IsRequiredPoliceClearnece { get; set; }

        public string RequiredPoliceClearnece { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
