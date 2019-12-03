using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("WorkOrders_Tests")]
    public class WorkOrders_Tests
    {
        [Key]
        [Column(Order = 0)]
        public virtual WorkOrders WorkOrders { get; set; }
        
        [Key]
        [Column(Order = 1)]
        public virtual Tests Tests { get; set; }

        public virtual WorkOrders_Samples WorkOrders_Samples { get; set; }

        public virtual Employee Employee { get; set; }

        [Required(ErrorMessage = "Please indicate if test is required in assay")]
        [Display(Name = "Is this Test required in Assay?")]
        public bool Required { get; set; }

        [Required(ErrorMessage = "Please enter a scheduled date for test")]
        [Display(Name = "Date Scheduled for Test")]
        public DateTime DateScheduled { get; set; }

        [Display(Name = "Date Test Completed")]
        public DateTime DateCompleted { get; set; }

        [Display(Name = "Re-Run Needed?")]
        public bool RerunNeeded { get; set; }

        [Display(Name = "Is this an Additional Test?")]
        public bool Additional { get; set; }

        [Display(Name = "Has this Test been approved by Customer?")]
        public bool Approved { get; set; }
    }
}