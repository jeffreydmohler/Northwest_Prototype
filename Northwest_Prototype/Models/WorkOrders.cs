using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("WorkOrders")]
    public class WorkOrders
    {
        [Key]
        [Required]
        public int WorkOrderID { get; set; }

        public virtual Assay Assay { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Compound Compound { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Results Results { get; set; }

        public virtual WorkOrders_Samples WorkOrders_Samples { get; set; }

        [Required(ErrorMessage = "Please enter a Due Date")]
        [Display(Name = "Due Date")]
        public DateTime DateDue { get; set; }

        [Required(ErrorMessage = "Please enter Status of Work Order")]
        [Display(Name = "Work Order Status")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Please enter the Quoted Price")]
        [Display(Name = "Quote Price")]
        public decimal QuotePrice { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }

        [Display(Name = "Billed?")]
        public bool Billed { get; set; }

        [Display(Name = "Paid?")]
        public bool Paid { get; set; }

        public string Comments { get; set; }

        [Display(Name = "Quantity(mg)")]
        public int Quantity { get; set; }

        [Display(Name = "Date Compound Received")]
        public DateTime DateReceived { get; set; }

        [Display(Name = "Received By")]
        public string ReceivedBy { get; set; }

        [Display(Name = "Compound Weight According to Client")]
        public decimal CompoundWeight_Client { get; set; }

        [Display(Name = "Actual Weight of Compound")]
        public decimal CompoundWeight_Actual { get; set; }

        [Display(Name = "Compound Mass")]
        public decimal CompoundMass { get; set; }

        [Display(Name = "Time Confirmation Sent")]
        public DateTime DateTimeConfirmation { get; set; }

        
        [Display(Name = "Maximum Tolerated Dose")]
        public decimal MTD { get; set; }
    }
}