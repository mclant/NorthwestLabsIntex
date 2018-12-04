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
        [Required]
        [DisplayName("LT Number")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LTNumber { get; set; }

        [Required]
        [DisplayName("Compound Name")]
        public String CompoundName { get; set; }

        [Required]
        [DisplayName("Maximum Dose")]
        public float MaximumDose { get; set; }
    }
}