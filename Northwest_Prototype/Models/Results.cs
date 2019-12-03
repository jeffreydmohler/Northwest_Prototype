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

        public string Result { get; set; }
    }
}