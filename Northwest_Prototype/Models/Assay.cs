using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwest_Prototype.Models
{
    [Table("Assay")]
    public class Assay
    {

        [Key]
        [Required]
        [StringLength(6, ErrorMessage = "Must be shorter then 6 characters")]
        public string AssayID { get; set; }

        [Required(ErrorMessage = "Please enter a Assay Name")]
        [Display(Name = "Assay")]
        public string AssayName { get; set; }

        [Display(Name = "Assay Protocol")]
        public string AssayProtocol { get; set; }

        [Display(Name = "Estimated Days to Complete Assay")]
        public int EstDayDuration { get; set; }

        public virtual ICollection<AssayToTest> AssayToTests { get; set; }

    }
}