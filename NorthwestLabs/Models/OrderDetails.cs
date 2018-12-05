using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // OrderDetails Table
    [Table("OrderDetails")]
    public class OrderDetails
    {
        #region CompositePrimaryKey
        [Key, Column(Order = 1), ForeignKey("orders")]
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID is required.")]
        public int OrderID { get; set; }
        // Link back to the Orders Table
        public virtual Orders orders { get; set; }

        [Key, Column(Order = 2), ForeignKey("compounds")]
        [DisplayName("LT Number")]
        [Required(ErrorMessage = "LT Number is required.")]
        public int LTNumber { get; set; }
        // Link back to the Compound Table
        public virtual Compounds compounds { get; set; }
        #endregion
    }
}