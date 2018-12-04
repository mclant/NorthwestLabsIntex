using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // AssayTypes Table
    [Table("AssayTypes")]
    public class AssayTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Assay Type ID")]
        [Required(ErrorMessage = "Assay Type ID is required.")]
        public int AssayTypeID { get; set; }
        // Link back to AssayInstances Table
        public virtual AssayInstances assayinstances { get; set; }

        [StringLength(30, ErrorMessage = "Assay Name must not exceed 30 characters.")]
        [DisplayName("Assay Name")]
        [Required(ErrorMessage = "Assay Name is required.")]
        public string AssayName { get; set; }

        [StringLength(10000, ErrorMessage = "Assay Protocol must not exceed 10,000 characters.")]
        [DisplayName("Assay Protocol")]
        [Required(ErrorMessage = "Assay Protocol is required.")]
        public string AssayProtocol { get; set; }
    }
}