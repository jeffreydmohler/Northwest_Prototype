using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Required(ErrorMessage = "Please enter Employee ID")]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        public virtual Users Users { get; set; }

        public virtual Position Position { get; set; }

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

        [Required(ErrorMessage = "Please enter Zip")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PrimaryPhone { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter Email")]
        public string PrimaryEmail { get; set; }
    }
}