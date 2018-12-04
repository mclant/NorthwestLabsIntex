using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Employee Positions")]
    public class EmployeePositions
    {
        [Key]
        [DisplayName("Position ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeePositionID { get; set; }

        [Required(ErrorMessage = "Position Description is required.")]
        [StringLength(50)]
        [DisplayName("Position Description")]
        public string PositionDesc { get; set; }
    }
}