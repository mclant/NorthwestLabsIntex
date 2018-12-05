using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{ 
    // Orders Table
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Order ID")]
        public int OrderID { get; set; }
        // Link back to the OrderDetails Table
        public virtual OrderDetails orderdetails { get; set; }
        // Link back to the OrderComments Table
        public virtual OrderComments ordercomments { get; set; }

        // Link to the Customers Table
        [Required(ErrorMessage = "You must enter your Customer ID")]
        [DisplayName("Customer ID")]
        public int CustomerID { get; set; }
        public virtual Customers customers { get; set; }

        [StringLength(255, ErrorMessage = "Customer Comments must not exceed 255 characters.")]
        [DisplayName("Customer Comments")]
        public string CustomerComments { get; set; }

        [StringLength(255, ErrorMessage = "Lab Comments must not exceed 255 characters.")]
        [DisplayName("Lab Comments")]
        public string LabComments { get; set; }

        [DisplayName("Order Total")]
        public float? OrderTotal { get; set; }

        [DisplayName("Order Discount")]
        public float? OrderDiscount { get; set; }

        // Link to the OrderStatuses Table
        [DisplayName("Order Status ID")]
        public int? OrderStatusID { get; set; }
        public virtual OrderStatuses orderstatuses { get; set; }

        // Link to the Employees Table
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

        // Link to the Invoices Table
        [DisplayName("Invoice ID")]
        public int? InvoiceID { get; set; }
        public virtual Invoices invoices { get; set; }
    }
}