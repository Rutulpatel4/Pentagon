namespace Pentagon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userInfo")]
    public partial class userInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string firstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Email")]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Role")]
        public string currentAccess { get; set; }

        [DisplayName("Mobile Number")]
        public int? MobileNumber { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Image")]
        public string imageUrl { get; set; }

        [Required]
        [StringLength(128)]
        public string Id { get; set; }
    }
}
