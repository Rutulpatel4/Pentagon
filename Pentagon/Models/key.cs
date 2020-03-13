namespace Pentagon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("key")]
    public partial class key
    {
        public int keyId { get; set; }

        [Required]
        [StringLength(50)]
        public string keyTrackingNumber { get; set; }

        public int vehicleId { get; set; }

        public virtual vehicle vehicle { get; set; }
    }
}
