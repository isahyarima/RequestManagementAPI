namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeNextOfKin
    {
        [Key]
        public Guid EmployeeNextOfKinId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        [StringLength(100)]
        public string emailAddress { get; set; }

        public Guid? RelationshipId { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? EmployeeId { get; set; }

        public int? TitleId { get; set; }
    }
}
