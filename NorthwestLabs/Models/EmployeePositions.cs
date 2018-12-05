using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    // EmployeePositions Table
    [Table("Employee Positions")]
    public class EmployeePositions
    {
        [Key, Required]
        [DisplayName("Position ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeePositionID { get; set; }
        // Link back to the Orders Table
        public virtual ICollection<Employees> employees { get; set; }

        [Required(ErrorMessage = "Position Description is required.")]
        [StringLength(50, ErrorMessage = "Position Description must not exceed 50 characters.")]
        [DisplayName("Position Description")]
        public string PositionDesc { get; set; }
    }
}