namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_MembershipAndClub
    {
        [Key]
        public Guid MembershipAndClubId { get; set; }

        [StringLength(200)]
        public string NameOfOganisation { get; set; }

        public string Address { get; set; }

        [StringLength(50)]
        public string MembershipStatus { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? EmployeeId { get; set; }
    }
}
