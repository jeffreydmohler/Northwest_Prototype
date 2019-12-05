using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Required(ErrorMessage = "Please enter Customer ID")]
        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        public string UserID { get; set; }

        public virtual Users users { get; set; }

        [Required(ErrorMessage = "Please enter First Name")]
        [Display(Name = "First Name")]
        public string CustFirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        [Display(Name = "Last Name")]
        public string CustLastName { get; set; }

        [Required(ErrorMessage = "Please enter Street Address")]
        [Display(Name = "Street Address")]
        public string CustAdd1 { get; set; }

        [Display(Name = "Apt/Suite #")]
        public string CustAdd2 { get; set; }

        [Required(ErrorMessage = "Please enter City")]
        [Display(Name = "City")]
        public string CustCity { get; set; }

        [Required(ErrorMessage = "Please enter State")]
        public string CustState { get; set; }

        [Required(ErrorMessage = "Please enter Zip")]
        public string CustZip { get; set; }

        [Required(ErrorMessage = "Please enter Zip")]
        public string CustCountry { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string CustPhone { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter Email")]
        public string CustEmail { get; set; }

        [Display(Name = "Billing Street Address")]
        public string CustBillAdd1 { get; set; }

        [Display(Name = "Billing Apt/Suite #")]
        public string CustBillAdd2 { get; set; }

        [Display(Name = "Billing City")]
        public string CustBillCity { get; set; }

        [Display(Name = "Billing State")]
        public string CustBillState { get; set; }

        [Display(Name = "Billing Zip")]
        public string CustBillZip { get; set; }

        [Display(Name = "Billing Country")]
        public string CustBillCountry { get; set; }

        [CreditCard]
        [Display(Name = "Credit Card Number")]
        public string CustCreditCard { get; set; }
    }
}