using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        [Required]
        public int CompoundID { get; set; }

        [Display(Name = "Compound Name")]
        [Required(ErrorMessage = "Please enter a Compound Name")]
        public string CompoundDesc { get; set; }

    }
}