using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        [DisplayName("Employee ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Position ID is required.")]
        [DisplayName("Position ID")]
        public int PositionID { get; set; }

        public virtual EmployeePositions employeepositions { get; set; }

        [Required(ErrorMessage = "Hourly Wage ID is required.")]
        [DisplayName("Hourly Wage ID")]
        public int HourlyWageID { get; set; }

        public virtual HourlyWages hourlywages { get; set; }

        [Required(ErrorMessage = "Employee First Name is required.")]
        [StringLength(30)]
        [DisplayName("Employee First Name")]
        public string EmployeeFName { get; set; }

        [Required(ErrorMessage = "Employee Last Name is required.")]
        [StringLength(30)]
        [DisplayName("Employee Last Name")]
        public string EmployeeLName { get; set; }

        [Required(ErrorMessage = "Employee Phone is required.")]
        [StringLength(30)]
        [DisplayName("Employee Phone")]
        public string EmployeePhone { get; set; }

        [Required(ErrorMessage = "Employee Email is required.")]
        [StringLength(30)]
        [DisplayName("Employee Email")]
        public string EmployeeEmail { get; set; }

        [Required(ErrorMessage = "Login Username is required.")]
        [StringLength(30)]
        [DisplayName("Login Username")]
        public string LoginUserName { get; set; }

        public virtual Logins logins { get; set; }

        [Required(ErrorMessage = "Location ID is required.")]
        [DisplayName("Location ID")]
        public int LocationID { get; set; }

        public virtual Locations locations { get; set; }
    }
}