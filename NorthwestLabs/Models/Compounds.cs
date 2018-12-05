using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // Compound Table
    [Table("Compounds")]
    public class Compounds
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("LT Number")]
        [Required]
        public int LTNumber { get; set; }
        // Link back to AssayInstances Table
        public ICollection<AssayInstances> assayinstances { get; set; }
        // Link back to Samples Table
        public ICollection<Samples> samples { get; set; }
        // Link back to the OrderDetails Table
        public ICollection<OrderDetails> orderdetails { get; set; }

        [StringLength(30, ErrorMessage ="Compound Name must not exceed 30 characters.")]
        [DisplayName("Compound Name")]
        [Required(ErrorMessage = "Compound Name is required.")]
        public string CompoundName { get; set; }

        [DisplayName("Maximum Dose")]
        [Required(ErrorMessage = "Maximum Dose is required.")]
        public float? MaximumDose { get; set; }
    }
}