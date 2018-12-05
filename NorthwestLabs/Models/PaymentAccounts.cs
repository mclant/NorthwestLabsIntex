using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // PaymentAccounts Table
    [Table("PaymentAccounts")]
    public class PaymentAccounts
    {
        // Link to the Customers Table
        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "Customer ID is required.")]
        public int CustomerID { get; set; }
        // Link back to the Customers Table
        public virtual Customers customer { get; set; }

        #region CompositePrimaryKey
        [Key, Column(Order = 1)]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "Account Number is required.")]
        public int AccountNum { get; set; }

        [Key, Column(Order = 2)]
        [DisplayName("Routing Number")]
        [Required(ErrorMessage = "Routing Number is required.")]
        public int RoutingNum { get; set; }
        #endregion
    }
}
