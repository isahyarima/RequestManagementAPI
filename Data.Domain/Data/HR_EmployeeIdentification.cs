namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeIdentification
    {
        [Key]
        public Guid IdentificationId { get; set; }

        public Guid? IdentificationTypeId { get; set; }

        [StringLength(50)]
        public string IndentityNumber { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [StringLength(200)]
        public string PlaceIssued { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? EmployeeId { get; set; }
    }
}
