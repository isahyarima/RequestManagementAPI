namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_Country
    {
        [Key]
        public Guid CountryId { get; set; }

        [StringLength(100)]
        public string CountryName { get; set; }
    }
}
