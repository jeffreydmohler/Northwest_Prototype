using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("AssayDetails")]
    public class AssayDetails
    {
        [Key]
        public virtual Assay Assay { get; set; }

        [Key]
        public virtual Tests Tests { get; set; }
    }
}