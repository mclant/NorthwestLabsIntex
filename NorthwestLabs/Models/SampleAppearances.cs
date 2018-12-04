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
        [Key]                   // Primary Key
        [Required]
        [DisplayName("Appearance ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppearanceID { get; set; }

        [Required]
        [DisplayName("Appearance Description")]
        public String AppearanceDesc { get; set; }
    }
}