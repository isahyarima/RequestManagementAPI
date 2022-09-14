namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MIS_StudentGuardian
    {
        [Key]
        public Guid GuardianId { get; set; }

        public Guid StudentId { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string MiddleName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        public string Profession { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public string OfficeAddress { get; set; }

        public int? CountryId { get; set; }

        public int? RelationshipId { get; set; }

        [StringLength(200)]
        public string LgaNonNig { get; set; }

        [StringLength(200)]
        public string StateNonNig { get; set; }

        public Guid? TenantId { get; set; }

        public int? LocalGovtId { get; set; }

        public int? StateId { get; set; }

        public DateTime? DateMidified { get; set; }
    }
}
