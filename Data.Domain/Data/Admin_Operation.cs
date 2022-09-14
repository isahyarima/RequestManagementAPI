namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin_Operation
    {
        [Key]
        public Guid OperationId { get; set; }

        [StringLength(100)]
        public string OperationName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
