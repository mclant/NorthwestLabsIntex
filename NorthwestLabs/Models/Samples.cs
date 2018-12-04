using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // Samples Table
    [Table("Samples")]
    public class Samples
    {
        [Key]                   // Primary Key
        [Required(ErrorMessage = "The Compound Sequence Code is required")]
        [DisplayName("Compound Sequence Code")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompoundSequenceCode { get; set; }

        // Link to the Compound Table
        [Required(ErrorMessage = "The LT Number for the sample compound is required")]
        [DisplayName("LT Number")]
        public int LTNumber { get; set; }
        public virtual Compounds compound { get; set; }

        [DisplayName("Date Arrived")]
        public Nullable<DateTime> DateArrived { get; set; }

        [StringLength(30, ErrorMessage = "Received By must be less than 30 characters in length")]
        [DisplayName("Received By")]
        public string ReceivedBy { get; set; }

        // Link to the SampleAppearances Table
        [DisplayName("Appearance ID")]
        public Nullable<int> AppearanceID { get; set; }
        public virtual SampleAppearances sampleAppearance { get; set; }

        [Required(ErrorMessage = "The weight in milligrams is required")]
        [DisplayName("Weight (mg)")]
        public float Weight { get; set; }

        [DisplayName("Molecular Mass")]
        public Nullable<float> MolecularMass { get; set; }
    }
}