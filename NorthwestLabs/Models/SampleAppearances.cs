using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class SampleAppearances
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Appearance ID")]
        [Required(ErrorMessage ="Appearance ID is required.")]
        public int AppearanceID { get; set; }

        [StringLength(30, ErrorMessage ="Appearance Description must not exceed 30 characters."]
        [DisplayName("Appearance Description")]
        [Required(ErrorMessage ="Appearance Description is required.")]
        public string AppearanceDesc { get; set; }
    }
}