using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("OrderStatuses")]
    public class OrderStatuses
    {
        [Key]
        [DisplayName("Order Status ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderStatusID { get; set; }

        public virtual Orders orders { get; set; }

        [DisplayName("Order Status Description")]
        [StringLength(30)]
        public string OrderStatusDesc { get; set; }

    }
}