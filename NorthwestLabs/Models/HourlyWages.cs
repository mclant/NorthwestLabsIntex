using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("HourlyWages")]
    public class HourlyWages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Hourly Wage ID")]
        public int HourlyWageID { get; set; }

        public virtual Employees employees { get; set; }

        [Required(ErrorMessage = "Hourly Wage Amount is required.")]
        [DisplayName("Hourly Wage Amount")]
        public int HourlyWageAmount { get; set; }
    }


}