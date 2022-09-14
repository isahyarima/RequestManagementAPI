namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Designation
    {
        [Key]
        public Guid DesignationId { get; set; }

        [StringLength(100)]
        public string DesignationName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
