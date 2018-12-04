using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // TestMaterials Table
    [Table("TestMaterials")]
    public class TestMaterials
    {
        #region CompositePrimaryKey
        [Key, Column(Order = 1)]
        [DisplayName("Test ID")]
        public int TestID { get; set; }
        // Link back to SampleTests Table
        public virtual SampleTests sampletests { get; set; }

        [Key, Column(Order = 2)]
        [DisplayName("Material ID")]
        [Required(ErrorMessage = "Material ID is required.")]
        public int MaterialID { get; set; }
        // Link back to Materials Table
        public virtual Materials materials { get; set; }
        #endregion

        [DisplayName("Material Quantity")]
        [Required(ErrorMessage = "Material Quantity is required")]
        public int MaterialQty { get; set; }
    }
}