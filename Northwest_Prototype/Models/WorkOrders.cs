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
        public int LT_Number { get; set; }

        public string AssayID { get; set; }
        public virtual Assay Assay { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public int CompoundID { get; set; }
        public virtual Compound Compound { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        public int ResultsID { get; set; }
        public virtual Results Results { get; set; }

        [Required(ErrorMessage = "Please enter a Due Date")]
        [Display(Name = "Due Date")]
        public DateTime DateDue { get; set; }

        [Required(ErrorMessage = "Please enter Status of Work Order")]
        [Display(Name = "Work Order Status")]
        public int OrderStatus { get; set; }

        [Required(ErrorMessage = "Please enter the Quoted Price")]
        [Display(Name = "Quote Price")]
        public decimal QuotePrice { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }

        [Display(Name = "Billed?")]
        public decimal Billed { get; set; }

        [Display(Name = "Paid?")]
        public decimal Paid { get; set; }

        public string Comments { get; set; }

        [Display(Name = "Quantity(mg)")]
        public int Quantity { get; set; }

        [Display(Name = "Date Compound Received")]
        public DateTime DateReceived { get; set; }

        [Display(Name = "Received By")]
        public int ReceivedBy { get; set; }

        [Display(Name = "Compound Weight According to Client")]
        public decimal CompoundWeight_Client { get; set; }

        [Display(Name = "Actual Weight of Compound")]
        public decimal CompoundWeight_Actual { get; set; }

        [Display(Name = "Compound Mass")]
        public decimal CompoundMass { get; set; }

        [Display(Name = "Date Confirmation Sent")]
        public DateTime DateTimeConfirmation { get; set; }
        
        [Display(Name = "Maximum Tolerated Dose")]
        public decimal MTD { get; set; }
    }
}