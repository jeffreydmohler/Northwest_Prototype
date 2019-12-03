using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("Position")]
    public class Position
    {
        [Key]
        [Required]
        public int PositionID { get; set; }

        [Display(Name = "Position")]
        public string PositionTitle { get; set; }

        [Display(Name = "Salary")]
        public double Salary { get; set; }

        [Display(Name = "Wage or Hourly Rate")]
        public decimal Wage { get; set; }
    }
}