using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // TestHours Table
    [Table("TestHours")]
    public class TestHours
    {
        #region CompositePrimaryKey
        [Key, Column(Order = 1), ForeignKey("sampletests")]
        [DisplayName("Test ID")]
        public int TestID { get; set; }
        // Link back to SampleTests Table
        public virtual SampleTests sampletests { get; set; }

        [Key, Column(Order = 2), ForeignKey("employees")]
        [DisplayName("Employee ID")]
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeID { get; set; }
        // Link back to Employees Table
        public virtual Employees employees { get; set; }
        #endregion

        [DisplayName("Hour Count")]
        [Required(ErrorMessage = "Hour Count is required")]
        public float HourCount { get; set; }
    }
}