using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("Results")]
    public class Results
    {
        [Key]
        public int ResultsID { get; set; }

        [Display(Name = "Raw Quantitative Results")]
        public string QuantResultRaw { get; set; }

        [Display(Name = "Summary Quantitative Results")]
        public string QuantResultSum { get; set; }

        [Display(Name = "Qualitative Results")]
        public string QualResult { get; set; }
    }
}