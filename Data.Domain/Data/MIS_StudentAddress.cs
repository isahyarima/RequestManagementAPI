namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MIS_StudentAddress
    {
        [Key]
        public Guid StudentAddressId { get; set; }

        public Guid? StudentId { get; set; }

        [StringLength(50)]
        public string HouseNumber { get; set; }

        public string Address { get; set; }

        [StringLength(100)]
        public string Ward { get; set; }

        public int? LocalGovtId { get; set; }

        public int? StateId { get; set; }

        [StringLength(200)]
        public string LgaNonNig { get; set; }

        [StringLength(200)]
        public string StateNonNig { get; set; }

        public int? CountryId { get; set; }

        [StringLength(50)]
        public string PHouseNumber { get; set; }

        public string PAddress { get; set; }

        [StringLength(100)]
        public string PWard { get; set; }

        public int? PLocalGovtId { get; set; }

        public int? PStateId { get; set; }

        [StringLength(200)]
        public string PLgaNonNig { get; set; }

        [StringLength(200)]
        public string PStateNonNig { get; set; }

        public int? PCountryId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }
    }
}
