using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    public class AssayToTest
    {
        [Key]
        public int AssayToTestID { get; set; }
        public int TestID { get; set; }
        public string AssayID { get; set; }

        public virtual Assay Assay { get; set; }
        public virtual Tests Tests { get; set; }
    }
}