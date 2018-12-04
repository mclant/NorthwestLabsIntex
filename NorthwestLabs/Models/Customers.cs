using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Customer ID")]
        public int CustomerID { get; set; }

        public virtual Orders order { get; set; }

        [Required(ErrorMessage = "Customer Name is required.")]
        [StringLength(30)]
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Customer Address is required.")]
        [StringLength(30)]
        [DisplayName("Customer Address")]
        public string CustomerAddress { get; set; }

        [Required(ErrorMessage = "Customer Phone is required.")]
        [StringLength(30)]
        [DisplayName("Customer Phone")]
        public string CustomerPhone { get; set; }

        [Required(ErrorMessage = "Customer Email is required.")]
        [StringLength(30)]
        [EmailAddress]
        [DisplayName("Customer Email")]
        public string CustomerEmail { get; set; }
        
        [Required(ErrorMessage = "Customer Balance is required.")]
        [DisplayName("Customer Balance")]
        public decimal CustomerBalance { get; set; }

        [Required(ErrorMessage = "Login Username is required.")]
        [StringLength(30)]
        [DisplayName("Login Username")]
        public string LoginUserName { get; set; }

        public virtual Logins logins { get; set; }
    }
}