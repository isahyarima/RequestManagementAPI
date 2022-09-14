namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_ChartOfAccount
    {
        [Key]
        public Guid ChartOfAccountId { get; set; }

        [StringLength(50)]
        public string ChartOfAccountName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
