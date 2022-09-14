namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_SalaryGradeMapping
    {
        [Key]
        public Guid SalaryGradeMappingId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? SalaryTemplateId { get; set; }

        public Guid? TenantId { get; set; }

        public DateTime? DateRegistered { get; set; }
    }
}
