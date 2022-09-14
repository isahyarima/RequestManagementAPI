namespace Data.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeaveType")]
    public partial class LeaveType
    {
        public int LeaveTypeId { get; set; }

        [StringLength(50)]
        public string LeaveTypeName { get; set; }
    }
}
