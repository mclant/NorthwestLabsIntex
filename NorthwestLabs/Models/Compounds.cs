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
        [Required(ErrorMessage = "LT Number is required.")]
        public int LTNumber { get; set; }
        // Link back to AssayInstances Table
        public virtual AssayInstances assayinstances { get; set; }
        // Link back to Samples Table
        public virtual Samples samples { get; set; }

        [StringLength(30, ErrorMessage ="Compound Name must not exceed 30 characters.")]
        [DisplayName("Compound Name")]
        [Required(ErrorMessage = "Compound Name is required.")]
        public string CompoundName { get; set; }

        [DisplayName("Maximum Dose")]
        [Required(ErrorMessage = "Maximum Dose is required.")]
        public float? MaximumDose { get; set; }
    }
}