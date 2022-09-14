namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_LeaveBook
    {
        [Key]
        public Guid LeaveBookId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? DepartmentId { get; set; }

        public Guid? DepartmentunitId { get; set; }

        public Guid? LeaveTypeId { get; set; }

        public DateTime? LeaveStartDate { get; set; }

        public DateTime? LeaveEndDate { get; set; }

        public DateTime? ResumptionDate { get; set; }

        public int? ApproveDays { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? ApprivalStatusId { get; set; }

        public DateTime? DateApproved { get; set; }

        public Guid? ApproveBy { get; set; }

        [StringLength(50)]
        public string ApprovalWorkFlowReference { get; set; }

        public bool? IsPayLeaveApplicable { get; set; }

        [StringLength(500)]
        public string AddressOnLeave { get; set; }

        [StringLength(50)]
        public string Year { get; set; }
    }
}
