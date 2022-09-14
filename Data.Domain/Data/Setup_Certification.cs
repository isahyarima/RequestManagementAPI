namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_Certification
    {
        [Key]
        public Guid CertificationId { get; set; }

        [StringLength(200)]
        public string CertificationName { get; set; }
    }
}
