namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admission_RequireDocument
    {
        [Key]
        public Guid AdmissionRequireDocumentId { get; set; }

        public Guid? AcademicDegreeTypeId { get; set; }

        public int? AdmissionTypeId { get; set; }

        [StringLength(500)]
        public string DocumentName { get; set; }

        public Guid? DocumentTypeId { get; set; }

        [StringLength(50)]
        public string DocumentSize { get; set; }

        public bool? IsRequired { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }
    }
}
