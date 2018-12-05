using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // Materials Table
    [Table("Materials")]
    public class Materials
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Material ID")]
        public int MaterialID { get; set; }
        // Link back to TestMaterials Table
        public ICollection<TestMaterials> testmaterials { get; set; }

        [DisplayName("Material Name")]
        [Required(ErrorMessage = "Material Name is required.")]
        [StringLength(30, ErrorMessage = "Material Name must not exceed 30 characters.")]
        public string MaterialName { get; set; }

        [DisplayName("Material Cost")]
        [Required(ErrorMessage ="Material Cost is required.")]
        public decimal MaterialCost { get; set; }
    }
}