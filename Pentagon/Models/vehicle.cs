namespace Pentagon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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

        [DisplayName("Id")]
        public int vehicleId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Type")]
        public string vehicleType { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Make")]
        public string make { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Model")]
        public string model { get; set; }

        [DisplayName("Year")]
        public int year { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("VIN")]
        public string vehicleIdentificationNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Stock Number")]
        public string vehiclesStockNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Trim Level")]
        public string trimLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<key> keys { get; set; }
    }
}
