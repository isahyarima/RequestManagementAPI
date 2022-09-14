namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_LocalGovt
    {
        [Key]
        public Guid LocalGovtId { get; set; }

        [StringLength(200)]
        public string LocalGovtName { get; set; }

        public int? StateId { get; set; }
    }
}
