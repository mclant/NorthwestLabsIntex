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
        [Required]
        [DisplayName("Compound Sequence Code")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompoundSequenceCode { get; set; }

        // Link to the Compound Table
        [DisplayName("LT Number")]
        public int LTNumber { get; set; }
        public virtual Compounds compound { get; set; }

        [DisplayName("Date Arrived")]
        public Nullable<DateTime> DateArrived { get; set; }

        [DisplayName("Received By")]
        public string ReceivedBy { get; set; }

        // Link to the SampleAppearances Table
        [DisplayName("Appearance ID")]
        public Nullable<int> AppearanceID { get; set; }
        public virtual SampleAppearances sampleAppearance { get; set; }

        [DisplayName("Weight (mg)")]
        public float Weight { get; set; }

        [DisplayName("Molecular Mass")]
        public Nullable<float> MolecularMass { get; set; }
    }
}