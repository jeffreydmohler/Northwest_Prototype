﻿using System;
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
        [Required(ErrorMessage = "Please enter Compound Sequence Code")]
        [Display(Name = "Compound Sequence Code")]
        public string CompoundSequenceCode { get; set; }

        public int LT_Number { get; set; }
        public virtual WorkOrders WorkOrders { get; set; }

        public int TestID { get; set; }
        public virtual Tests Tests { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        [Required(ErrorMessage = "Please indicate if test is required in assay")]
        [Display(Name = "Test Required in Assay?")]
        public bool Required { get; set; }

        [Required(ErrorMessage = "Please enter a scheduled date for test")]
        [Display(Name = "Date Scheduled for Test")]
        public DateTime DateScheduled { get; set; }

        [Display(Name = "Date Test Completed")]
        public DateTime DateCompleted { get; set; }

        [Display(Name = "Re-Run Needed?")]
        public bool RerunNeeded { get; set; }

        [Display(Name = "Additional Test?")]
        public bool AdditionalTests { get; set; }

        [Display(Name = "Approved by Customer?")]
        public bool Approved { get; set; }
    }
}