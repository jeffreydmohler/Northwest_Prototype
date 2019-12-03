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
        [Key, Column(Order = 0)]
        public string Assay2ID { get; set; }

        [Key, Column(Order = 1)]
        public int Test2ID { get; set; }

        public virtual Assay Assay { get; set; }

        public virtual Tests Tests { get; set; }

        public AssayDetails()
        {
            Assay2ID = Assay.AssayID;
            Test2ID = Tests.TestID;
        }
    }
}