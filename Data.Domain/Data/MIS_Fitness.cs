namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MIS_Fitness
    {
        [Key]
        public Guid FitnessId { get; set; }

        public Guid? StudentId { get; set; }

        public Guid? BloodGroupId { get; set; }

        [Required]
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
