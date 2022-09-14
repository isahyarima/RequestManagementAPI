namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MIS_StudentAdmissionNumber
    {
        [Key]
        public Guid StudentAdmissionNumberId { get; set; }

        public Guid? StudentId { get; set; }

        [StringLength(50)]
        public string AdmissionNumber { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(50)]
        public string AdmissionYear { get; set; }

        [StringLength(50)]
        public string Acronym { get; set; }
    }
}
