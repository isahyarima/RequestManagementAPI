namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_MilitaryService
    {
        [Key]
        public Guid MilitaryServiceId { get; set; }

        public Guid? EmployeeId { get; set; }

        [StringLength(200)]
        public string NameOfOganisation { get; set; }

        [StringLength(100)]
        public string BranchName { get; set; }

        [StringLength(50)]
        public string ServiceNumber { get; set; }

        public DateTime? EntryDate { get; set; }

        public DateTime? ExitDate { get; set; }

        [StringLength(100)]
        public string LastStation { get; set; }

        [StringLength(50)]
        public string RankAttained { get; set; }

        [StringLength(50)]
        public string DischargeCertificateNumber { get; set; }

        [StringLength(100)]
        public string ReasonForExit { get; set; }

        public DateTime? DateCreated { get; set; }

        public Guid? TenantId { get; set; }
    }
}
