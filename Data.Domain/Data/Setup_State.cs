namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_State
    {
        [Key]
        public Guid StateId { get; set; }

        [StringLength(200)]
        public string StateName { get; set; }
    }
}
