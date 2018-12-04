using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // Logins Table
    [Table("Logins")]
    public class Logins
    {
        [Key]
        [StringLength(30, ErrorMessage = "Login Username must not exceed 30 characters.")]
        [DisplayName("Login Username")]
        public int LoginUserName { get; set; }
        // Link back to Employees Table
        public virtual Employees employees { get; set; }
        // Link back to Customers Table
        public virtual Customers customers { get; set; }

        [StringLength(30, ErrorMessage = "Login Password must not exceed 30 characters.")]
        [DisplayName("Appearance Description")]
        [Required(ErrorMessage = "Login Password is required.")]
        public string LoginPassword { get; set; }
    }
}