using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // AssayInstances Table
    [Table("AssayInstances")]
    public class AssayInstances
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Assay Instance ID")]
        [Required(ErrorMessage = "Assay Instance ID is required.")]
        public int AssayInstanceID { get; set; }
        // Link back to SampleTests Table
        public virtual SampleTests sampletests { get; set; }

        [StringLength(255, ErrorMessage = "Assay Results must not exceed 255 characters.")]
        [DisplayName("Assay Results")]
        public string AssayResults { get; set; }

        // Link to the Compounds Table
        [DisplayName("LT Number")]
        [Required(ErrorMessage = "LT Number is required")]
        public int LTNumber { get; set; }
        public virtual Compounds compounds { get; set; }

        // Link to the AssayTypes Table
        [DisplayName("Assay Type ID")]
        [Required(ErrorMessage = "Assay Type ID is required")]
        public int AssayTypeID { get; set; }
        public virtual AssayTypes assaytypes { get; set; }
    }
}