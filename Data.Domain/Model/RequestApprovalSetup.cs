namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestApprovalSetup")]
    public partial class RequestApprovalSetup
    {
        public int RequestApprovalSetupId { get; set; }

        public int? RequestTypeId { get; set; }

        public int? EmployeeId { get; set; }

        public int? ApprovalOrder { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
