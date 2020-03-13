namespace Pentagon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vehicle")]
    public partial class vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehicle()
        {
            keys = new HashSet<key>();
        }

        public int vehicleId { get; set; }

        [Required]
        [StringLength(50)]
        public string vehicleType { get; set; }

        [Required]
        [StringLength(50)]
        public string make { get; set; }

        [Required]
        [StringLength(50)]
        public string model { get; set; }

        public int year { get; set; }

        [Required]
        [StringLength(50)]
        public string vehicleIdentificationNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string vehiclesStockNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string trimLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<key> keys { get; set; }
    }
}
