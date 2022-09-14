namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AcademicActivityType")]
    public partial class AcademicActivityType
    {
        public Guid AcademicActivityTypeId { get; set; }

        public string AcademicActivityTypeName { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
