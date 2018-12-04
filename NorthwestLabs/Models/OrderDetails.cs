using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Required(ErrorMessage = "Order ID is required")]
        public int OrderID { get; set; }

        public virtual Orders orders { get; set; }

        [Required(ErrorMessage = "LT Number is required")]
        public int LTNumber { get; set; }

        public virtual Compounds compounds { get; set; }
    }
}