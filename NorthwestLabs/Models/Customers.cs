using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // Customers Table
    [Table("Customers")]
    public class Customers
    {
        [Key]
        [DisplayName("Customer ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        // Link back to the Orders Table
        public virtual ICollection<Orders> order { get; set; }
        // Link back to the PaymentAccounts Table
        public virtual ICollection<PaymentAccounts> paymentaccounts { get; set; }

        [Required(ErrorMessage = "Customer Name is required.")]
        [StringLength(30, ErrorMessage = "Customer Name must not exceed 30 characters.")]
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Customer Address is required.")]
        [StringLength(30, ErrorMessage = "Customer Address must not exceed 30 characters.")]
        [DisplayName("Customer Address")]
        public string CustomerAddress { get; set; }

        [Required(ErrorMessage = "Customer Phone is required.")]
        [StringLength(30, ErrorMessage = "Customer Phone must not exceed 30 characters.")]
        [DisplayName("Customer Phone")]
        public string CustomerPhone { get; set; }

        [Required(ErrorMessage = "Customer Email is required.")]
        [StringLength(30, ErrorMessage = "Customer Email must not exceed 30 characters.")]
        [EmailAddress]
        [DisplayName("Customer Email")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Customer Balance is required.")]
        [DisplayName("Customer Balance")]
        public decimal CustomerBalance { get; set; }

        // Link to the Logins Table
        [Required(ErrorMessage = "Login Username is required.")]
        [StringLength(30, ErrorMessage = "Login Username must not exceed 30 characters.")]
        [DisplayName("Login Username")]
        [ForeignKey("logins")]
        public string LoginUserName { get; set; }
        public Logins logins { get; set; }
    }
}