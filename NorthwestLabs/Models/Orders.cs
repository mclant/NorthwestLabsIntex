using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Order ID")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "You must enter your Customer ID")]
        [DisplayName("Customer ID")]
        public int CustomerID { get; set; }

        [StringLength(255)]
        [DisplayName("Customer Comments")]
        public string CustomerComments { get; set; }

        [StringLength(255)]
        [DisplayName("Lab Comments")]
        public string LabComments { get; set; }

        [DisplayName("Order Total")]
        public float? OrderTotal { get; set; }

        [DisplayName("Order Discount")]
        public float? OrderDiscount { get; set; }

        [DisplayName("Order Status ID")]
        public float? OrderStatusID { get; set; }

        public virtual OrderStatuses orderstatuses { get; set; }

        [DisplayName("Employee ID")]
        public int? EmployeeID { get; set; }

        public virtual Employees employees { get; set; }

        [Required(ErrorMessage = "Today's Date is required.")]
        [DisplayName("Today's Date")]
        public DateTime DateRequested { get; set; }

        [Required(ErrorMessage = "Due Date is required.")]
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        [DisplayName("Date Completed")]
        public DateTime? DateCompleted { get; set; }

        [Required(ErrorMessage = "Quote is required. Please enter whether this is a quote or not.")]
        [DisplayName("Quote(Y/N)")]
        public bool Quote { get; set; }

        [DisplayName("Quote Price")]
        public decimal? QuotePrice { get; set; }

        [DisplayName("Invoice ID")]
        public int? InvoiceID { get; set; }

        public virtual Invoices invoices { get; set; }

    }
}