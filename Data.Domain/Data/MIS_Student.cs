namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MIS_Student
    {
        [Key]
        public Guid StudentId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(50)]
        public string NativeLaguage { get; set; }

        public bool? ApprovalStatusId { get; set; }

        [StringLength(50)]
        public string NIN { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }

        public int? ReligionId { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(200)]
        public string LgaNonNig { get; set; }

        [StringLength(200)]
        public string StateNonNig { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ApplicationDate { get; set; }

        [StringLength(50)]
        public string AdmissionNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public int? NationalityId { get; set; }

        [StringLength(200)]
        public string Hobbies { get; set; }

        public int? BloodGroupId { get; set; }

        public int? MaritalStatusId { get; set; }
    }
}
