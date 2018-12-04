using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("OrderComments")]
    public class OrderComments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Order Comment ID")]
        public int OrderCommentID { get; set; }

        [Required(ErrorMessage = "Order ID is required")]
        [DisplayName("Order ID")]
        public int OrderID { get; set; }

        public virtual Orders orders { get; set; }

        [Required(ErrorMessage = "Order Comment is required")]
        [StringLength(255, ErrorMessage = "Comment may not exceed 255 characters.")]
        [DisplayName("Order Comment")]
        public string OrderComment { get; set; }
    }
}