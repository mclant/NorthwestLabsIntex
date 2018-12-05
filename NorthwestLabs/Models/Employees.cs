using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // Employees Table
    [Table("Employees")]
    public class Employees
    {
        [Key]
        [DisplayName("Employee ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        // Link back to the Orders Table
        public ICollection<Orders> orders { get; set; }
        // LInk back to the TestHours Table
        public ICollection<TestHours> testhours { get; set; }

        // Link to the EmployeePositions Table
        [Required(ErrorMessage = "Position ID is required.")]
        [DisplayName("Position ID")]
        [ForeignKey("employeepositions")]
        public int PositionID { get; set; }
        public virtual EmployeePositions employeepositions { get; set; }

        // Link to the HourlyWages Table
        [Required(ErrorMessage = "Hourly Wage ID is required.")]
        [DisplayName("Hourly Wage ID")]
        [ForeignKey("hourlywages")]
        public int HourlyWageID { get; set; }
        public HourlyWages hourlywages { get; set; }

        [Required(ErrorMessage = "Employee First Name is required.")]
        [StringLength(30, ErrorMessage = "Employee First Name must not exceed 30 characters.")]
        [DisplayName("Employee First Name")]
        public string EmployeeFName { get; set; }

        [Required(ErrorMessage = "Employee Last Name is required.")]
        [StringLength(30, ErrorMessage = "Employee Last Name must not exceed 30 characters.")]
        [DisplayName("Employee Last Name")]
        public string EmployeeLName { get; set; }

        [Required(ErrorMessage = "Employee Phone is required.")]
        [StringLength(30, ErrorMessage = "Employee Phone must not exceed 30 characters.")]
        [DisplayName("Employee Phone")]
        public string EmployeePhone { get; set; }

        [Required(ErrorMessage = "Employee Email is required.")]
        [StringLength(30, ErrorMessage = "Employee Email must not exceed 30 characters.")]
        [DisplayName("Employee Email")]
        public string EmployeeEmail { get; set; }

        // Link to the Logins Table
        [Required(ErrorMessage = "Login Username is required.")]
        [StringLength(30, ErrorMessage = "Login Username must not exceed 30 characters.")]
        [DisplayName("Login Username")]
        [ForeignKey("logins")]
        public string LoginUserName { get; set; }
        public virtual Logins logins { get; set; }

        // Link to the Locations Table
        [Required(ErrorMessage = "Location ID is required.")]
        [DisplayName("Location ID")]
        [ForeignKey("locations")]
        public int LocationID { get; set; }
        public virtual Locations locations { get; set; }
    }
}
