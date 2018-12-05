using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // Locations Table
    [Table("Locations")]
    public class Locations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Location ID")]
        public int LocationID { get; set; }
        // Link back to the Employees table
        public virtual Employees employees { get; set; }

        [Required(ErrorMessage = "Location Name is required.")]
        [StringLength(30, ErrorMessage = "Location Name must not exceed 30 characters.")]
        [DisplayName("Location Name")]
        public string LocationName { get; set; }

        [Required(ErrorMessage = "Location Address is required.")]
        [StringLength(30, ErrorMessage = "Location Address must not exceed 30 characters.")]
        [DisplayName("Location Address")]
        public string LocationAddress { get; set; }

        [Required(ErrorMessage = "Location City is required.")]
        [StringLength(30, ErrorMessage = "Location City must not exceed 30 characters.")]
        [DisplayName("Location City")]
        public string LocationCity { get; set; }

        [Required(ErrorMessage = "Location State is required.")]
        [StringLength(30, ErrorMessage = "Location State must not exceed 30 characters.")]
        [DisplayName("Location State")]
        public string LocationState { get; set; }

        [StringLength(30, ErrorMessage = "Location ZIP must not exceed 30 characters.")]
        [DisplayName("Location ZIP")]
        public string LocationZIP { get; set; }

        [Required(ErrorMessage = "Location Country is required.")]
        [StringLength(30, ErrorMessage = "Location Country must not exceed 30 characters.")]
        [DisplayName("Location Country")]
        public string LocationCountry { get; set; }
    }
}