namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(500)]
        public string PlaceOfBirth { get; set; }

        [StringLength(200)]
        public string NativeLaguage { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreationDate { get; set; }

        public Guid? CreaterUserId { get; set; }

        public bool? IsModefied { get; set; }

        public Guid? DepartmentId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModificationDate { get; set; }

        public Guid? ModifierUserId { get; set; }

        public bool? IsDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DeletionDate { get; set; }

        public Guid? DeleterUserId { get; set; }

        public bool? IsApproved { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ApproveDate { get; set; }

        public Guid? ApproverUserId { get; set; }

        public int? StatusId { get; set; }

        public int? StateId { get; set; }

        public int? LocalGovtId { get; set; }

        public int? ReligionId { get; set; }

        public Guid? TenantId { get; set; }

        public int? NationaliltyId { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public Guid? DesignationId { get; set; }

        [StringLength(50)]
        public string EmployeeNumber { get; set; }

        public int? TitleId { get; set; }

        public int? EmployeeTypeId { get; set; }

        public int? MaritalStatusId { get; set; }

        [StringLength(200)]
        public string LgaNonNig { get; set; }

        [StringLength(200)]
        public string StateNonNig { get; set; }
    }
}
