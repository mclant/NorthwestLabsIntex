using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // CompanyInfo Table
    [Table("CompanyInfo")]
    public class CompanyInfo
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Company Information ID")]
        public int CompanyInfoID { get; set; }

        [StringLength(10000, ErrorMessage = "About Us must not exceed 10,000 characters.")]
        [DisplayName("About Us")]
        [Required(ErrorMessage = "About Us is required.")]
        public string AboutUs { get; set; }

        [StringLength(30, ErrorMessage = "Company Phone must not exceed 30 characters.")]
        [DisplayName("Company Phone")]
        [Required(ErrorMessage = "Company Phone is required.")]
        public string CompanyPhone { get; set; }

        [StringLength(100, ErrorMessage = "Company Address must not exceed 100 characters.")]
        [DisplayName("Company Address")]
        [Required(ErrorMessage = "Company Address is required.")]
        public string CompanyAddress { get; set; }

        [StringLength(30, ErrorMessage = "Company Email must not exceed 30 characters.")]
        [DisplayName("Company Email")]
        [Required(ErrorMessage = "Company Email is required.")]
        public string CompanyEmail { get; set; }

        [StringLength(10000, ErrorMessage = "About CEO must not exceed 10,000 characters.")]
        [DisplayName("About CEO")]
        [Required(ErrorMessage = "About CEO is required.")]
        public string AboutCEO { get; set; }
    }
}