using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // SampleAppearances Table
    [Table("SampleAppearances")]
    public class SampleAppearances
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Appearance ID")]
        public int AppearanceID { get; set; }
        // Link back to Samples Table
        public virtual ICollection<Samples> samples { get; set; }

        [StringLength(30, ErrorMessage ="Appearance Description must not exceed 30 characters.")]
        [DisplayName("Appearance Description")]
        [Required(ErrorMessage ="Appearance Description is required.")]
        public string AppearanceDesc { get; set; }
    }
}