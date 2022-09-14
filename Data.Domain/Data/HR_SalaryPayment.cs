namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_SalaryPayment
    {
        [Key]
        public Guid SalaryPaymentId { get; set; }

        public Guid? EmployeeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Month { get; set; }

        public Guid? SalaryTemplateId { get; set; }

        [Column(TypeName = "money")]
        public decimal? GrossWage { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDeduction { get; set; }

        [Column(TypeName = "money")]
        public decimal? OvertimeRate { get; set; }

        public int? TotalOvertimeHours { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOvertimeAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetWage { get; set; }

        public DateTime? DateRegistered { get; set; }

        public int? ProcessedId { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? DepartmentId { get; set; }

        public Guid? DesignationId { get; set; }

        public int? PaymentStatusId { get; set; }

        [StringLength(50)]
        public string MonthString { get; set; }
    }
}
