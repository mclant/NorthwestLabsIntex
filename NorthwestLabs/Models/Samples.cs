﻿using System;
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
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Compound Sequence Code")]
        public int CompoundSequenceCode { get; set; }
        // Link back to SampleTests Table
        public virtual ICollection<SampleTests> sampletests { get; set; }

        // Link to the Compounds Table
        [DisplayName("LT Number")]
        [Required(ErrorMessage = "LT Number is required.")]
        [ForeignKey("compounds")]
        public int LTNumber { get; set; }
        public virtual Compounds compounds { get; set; }

        [DisplayName("Date Arrived")]
        public DateTime? DateArrived { get; set; }

        [DisplayName("Received By")]
        [StringLength(30, ErrorMessage = "Received By must not exceed 30 characters.")]
        public string ReceivedBy { get; set; }

        // Link to the SampleAppearances Table
        [DisplayName("Appearance ID")]
        [ForeignKey("sampleappearances")]
        public int? AppearanceID { get; set; }
        public virtual SampleAppearances sampleappearances { get; set; }

        [Required(ErrorMessage = "Weight in milligrams is required.")]
        [DisplayName("Weight (mg)")]
        public float Weight { get; set; }

        [DisplayName("Molecular Mass")]
        public float? MolecularMass { get; set; }
    }
}