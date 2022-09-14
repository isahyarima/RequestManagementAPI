namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApprovalStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApprovalStatusId { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }
    }
}
