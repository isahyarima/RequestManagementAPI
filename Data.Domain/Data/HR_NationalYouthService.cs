namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_NationalYouthService
    {
        [Key]
        public Guid NationalYouthServiceId { get; set; }

        [StringLength(50)]
        public string CallupNumber { get; set; }

        public int? StateOfDeployementId { get; set; }

        public string PlaceOfAssignment { get; set; }

        public bool? DoYouHaveAnyAward { get; set; }

        [StringLength(50)]
        public string Award { get; set; }

        public bool? AnyExtention { get; set; }

        [StringLength(50)]
        public string ReasonForExtention { get; set; }

        public Guid? TenantId { get; set; }

        public Guid? EmployeeId { get; set; }
    }
}
