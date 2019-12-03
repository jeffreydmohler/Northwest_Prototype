using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("WorkOrders_Samples")]
    public class WorkOrders_Samples
    {
        [Key]
        [Column(Order = 0)]
        [Required(ErrorMessage ="Please enter LT Number")]
        [Display(Name = "Northwest Labs Test Number (LT Number)")]
        public int LT_Number { get; set; }

        [Key]
        [Column(Order = 1)]
        [Required(ErrorMessage = "Please enter Compound Sequence Code")]
        [Display(Name = "Compound Sequence Code")]
        public int CompoundSequenceCode { get; set; }
    }
}