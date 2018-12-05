using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // OrderStatuses Table
    [Table("OrderStatuses")]
    public class OrderStatuses
    {
        [Key]
        [DisplayName("Order Status ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderStatusID { get; set; }
        // Link back to the Orders Table
        public ICollection<Orders> orders { get; set; }

        [DisplayName("Order Status Description")]
        [StringLength(30, ErrorMessage = "Order Status Description must not exceed 30 characters.")]
        public string OrderStatusDesc { get; set; }
    }
}