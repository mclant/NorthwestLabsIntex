using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // OrderComments Table
    [Table("OrderComments")]
    public class OrderComments
    {
        // Link to the Orders Table
        [Required(ErrorMessage = "Order ID is required.")]
        [DisplayName("Order ID")]
        [ForeignKey("orders")]
        public int OrderID { get; set; }
        public virtual Orders orders { get; set; }

        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Order Comment ID")]
        public int OrderCommentID { get; set; }

        [Required(ErrorMessage = "Order Comment is required")]
        [StringLength(255, ErrorMessage = "Order Comment may not exceed 255 characters.")]
        [DisplayName("Order Comment")]
        public string OrderComment { get; set; }
    }
}