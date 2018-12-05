using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // Invoices Table
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        [DisplayName("Invoice ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceID { get; set; }

        [Required(ErrorMessage = "Payment Due Date is required.")]
        [DisplayName("Payment Due Date")]
        public DateTime PaymentDueDate { get; set; }

        [Required(ErrorMessage = "Early Payment Date is required.")]
        [DisplayName("Early Payment Date")]
        public DateTime EarlyPaymentDate { get; set; }

        [Required(ErrorMessage = "Early Payment Discount is required.")]
        [DisplayName("Early Payment Discount")]
        public float EarlyPaymentDiscount { get; set; }

        [DisplayName("Date Paid")]
        public DateTime? DatePaid { get; set; }
    }
}
