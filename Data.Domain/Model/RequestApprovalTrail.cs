namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestApprovalTrail")]
    public partial class RequestApprovalTrail
    {
        public int RequestApprovalTrailId { get; set; }

        public int? RequestApprovalSetupId { get; set; }

        public int? ApprovalStatusId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
