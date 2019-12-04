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

        public virtual Users Users { get; set; }

        [Required(ErrorMessage = "Please enter First Name")]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter Street Address")]
        [Display(Name = "Street Address")]
        public string Address1 { get; set; }

        [Display(Name = "Apt/Suite #")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Please enter City")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter Zip")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PrimaryPhone { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter Email")]
        public string PrimaryEmail { get; set; }

        [Display(Name = "Billing Street Address")]
        public string BillingAddress1 { get; set; }

        [Display(Name = "Billing Apt/Suite #")]
        public string BillingAddress2 { get; set; }

        [Display(Name = "Billing City")]
        public string BillingCity { get; set; }

        [Display(Name = "Billing State")]
        public string BillingState { get; set; }

        [Display(Name = "Billing Zip")]
        public string BillingZip { get; set; }

        [Display(Name = "Billing Country")]
        public string BillingCountry { get; set; }

        [CreditCard]
        [Display(Name = "Credit Card Number")]
        public string CreditCard { get; set; }
    }
}