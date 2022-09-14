namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeDepartment
    {
        [Key]
        public Guid EmployeeDepartmentId { get; set; }

        public Guid? EmployeeTypeId { get; set; }

        public Guid? AcademicFacultyId { get; set; }

        public Guid? AcademicDepartmentId { get; set; }

        public Guid? EmployeeId { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
