namespace Data.Domain.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application_StudentContact
    {
        [Key]
        public Guid StudentContactId { get; set; }

        public Guid? StudentId { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string OtherPhoneNumber { get; set; }

        [StringLength(200)]
        public string EmailAddress { get; set; }

        [StringLength(50)]
        public string ApplicationNumber { get; set; }

        public Guid? TenantId { get; set; }

        public bool? IsCompleted { get; set; }
    }
}
