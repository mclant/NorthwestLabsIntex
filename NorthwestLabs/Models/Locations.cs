using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Locations")]
    public class Locations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Location ID")]
        public int LocationID { get; set; }

        public virtual Employees employees { get; set; }

        [Required(ErrorMessage = "Location Name is required.")]
        [StringLength(30)]
        [DisplayName("Location Name")]
        public string LocationName { get; set; }

        [Required(ErrorMessage = "Location Address is required.")]
        [StringLength(30)]
        [DisplayName("Location Address")]
        public string LocationAddress { get; set; }

        [Required(ErrorMessage = "Location City is required.")]
        [StringLength(30)]
        [DisplayName("Location City")]
        public string LocationCity { get; set; }

        [Required(ErrorMessage = "Location State is required.")]
        [StringLength(30)]
        [DisplayName("Location State")]
        public string LocationState { get; set; }

        [Required(ErrorMessage = "Location ZIP is required.")]
        [StringLength(30)]
        [DisplayName("Location ZIP")]
        public string LocationZIP { get; set; }

        [Required(ErrorMessage = "Location Country is required.")]
        [StringLength(30)]
        [DisplayName("Location Country")]
        public string LocationCountry { get; set; }
    }
}