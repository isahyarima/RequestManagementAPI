namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_Student
    {
        [Key]
        public Guid StudentId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string NativeLaguage { get; set; }

        public bool? ApprovalStatusId { get; set; }

        [StringLength(50)]
        public string NIN { get; set; }

        public int? CountryOfBirthId { get; set; }

        public int? ReligionId { get; set; }

        [StringLength(200)]
        public string LgaNonNig { get; set; }

        [StringLength(200)]
        public string StateNonNig { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ApplicationDate { get; set; }

        public string ApplicationNumber { get; set; }

        public int? CountryOfNationalityId { get; set; }

        public int? StateId { get; set; }

        public int? LocalGovtId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }

        public bool? IsCompleted { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? LastLoginDate { get; set; }

        [StringLength(200)]
        public string ConfirmationId { get; set; }

        public bool? IsConfirmed { get; set; }

        [StringLength(200)]
        public string EmailAddress { get; set; }

        public bool? IsPasswordReset { get; set; }

        public Guid? RoleId { get; set; }

        public int? AdmissionStatusId { get; set; }
    }
}
