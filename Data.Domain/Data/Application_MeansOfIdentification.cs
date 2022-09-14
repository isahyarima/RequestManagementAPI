namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_MeansOfIdentification
    {
        [Key]
        public Guid IdentificationId { get; set; }

        public Guid? MeansOfIdentificationId { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [StringLength(50)]
        public string PlaceOfIssue { get; set; }

        [StringLength(50)]
        public string IndentificationNumber { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? IsCompleted { get; set; }

        public Guid? StudentId { get; set; }

        [StringLength(50)]
        public string ApplicationNumber { get; set; }
    }
}
