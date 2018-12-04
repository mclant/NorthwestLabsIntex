using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // SampleTests Table
    [Table("SampleTests")]
    public class SampleTests
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Sample Test ID")]
        [Required(ErrorMessage = "Sample Test ID is required.")]
        public int SampleTestID { get; set; }

        // Link to the Samples Table
        [DisplayName("Sample ID")]
        [Required(ErrorMessage = "Sample ID is required")]
        public int SampleID { get; set; }
        public virtual Samples samples { get; set; }

        [DisplayName("Materials Cost")]
        public decimal? MaterialsCost { get; set; }

        [DisplayName("Hours Cost")]
        public decimal? HoursCost { get; set; }

        [DisplayName("Base Cost")]
        public decimal? BaseCost { get; set; }

        // Link to the AssayInstances Table
        [DisplayName("Assay ID")]
        [Required(ErrorMessage = "Assay ID is required")]
        public int AssayID { get; set; }
        public virtual AssayInstances assayinstances { get; set; }

        // Link to the TestTypes Table
        [DisplayName("Test Type ID")]
        [Required(ErrorMessage = "Test Type ID is required")]
        public int TestTypeID { get; set; }
        public virtual TestTypes testtypes { get; set; }

        [DisplayName("Required for Assay")]
        [Required(ErrorMessage = "Required for Assay is required")]
        public bool RequiredForAssay { get; set; }

        [DisplayName("Active/Not Active")]
        public bool? Active_NotActive { get; set; }
    }
}