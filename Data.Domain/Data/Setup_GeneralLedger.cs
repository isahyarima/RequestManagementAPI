namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_GeneralLedger
    {
        [Key]
        public Guid GeneralLedgerId { get; set; }

        [StringLength(100)]
        public string GeneralLedgerName { get; set; }

        public Guid? TenantId { get; set; }

        public int? ChartOfAccountId { get; set; }

        [StringLength(50)]
        public string GL_Code { get; set; }

        public Guid? DepartmentId { get; set; }
    }
}
