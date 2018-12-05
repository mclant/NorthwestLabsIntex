using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // TestTypes Table
    [Table("TestTypes")]
    public class TestTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Test Type ID")]
        public int TestTypeID { get; set; }
        // Link back to SampleTests Table
        public virtual SampleTests sampletests { get; set; }

        [StringLength(30, ErrorMessage = "Test Type Name must not exceed 30 characters.")]
        [DisplayName("Test Type Name")]
        [Required(ErrorMessage = "Test Type Name is required.")]
        public string TestTypeName { get; set; }

        [StringLength(255, ErrorMessage = "Test Type Description must not exceed 255 characters.")]
        [DisplayName("Test Type Description")]
        [Required(ErrorMessage = "Test Type Description is required.")]
        public string TestTypeDesc { get; set; }

        [StringLength(10000, ErrorMessage = "Test Type Protocol must not exceed 10,000 characters.")]
        [DisplayName("Test Type Protocol")]
        [Required(ErrorMessage = "Test Type Protocol is required.")]
        public string TestTypeProtocol { get; set; }

        [DisplayName("Test Type Active")]
        [Required(ErrorMessage = "Test Type Active is required.")]
        public bool TestTypeActive { get; set; }

        [DisplayName("Average Test Duration")]
        [Required(ErrorMessage = "Average Test Duration is required.")]
        public DateTime AverageTestDuration { get; set; }
    }
}