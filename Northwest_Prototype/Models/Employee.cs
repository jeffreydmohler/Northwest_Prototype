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

        public string UserID { get; set; }
        public virtual Users Users { get; set; }

        public int PositionID { get; set; }
        public virtual Position Position { get; set; }

        [Required(ErrorMessage = "Please enter First Name")]
        [Display(Name = "First Name")]
        public string EmpFirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        [Display(Name = "Last Name")]
        public string EmpLastName { get; set; }

        [Required(ErrorMessage = "Please enter Street Address")]
        [Display(Name = "Street Address")]
        public string EmpAddress1 { get; set; }

        [Display(Name = "Apt/Suite #")]
        public string EmpAddress2 { get; set; }

        [Required(ErrorMessage = "Please enter City")]
        [Display(Name = "City")]
        public string EmpCity { get; set; }

        [Required(ErrorMessage = "Please enter State")]
        public string EmpState { get; set; }

        [Required(ErrorMessage = "Please enter Zip")]
        public string EmpZip { get; set; }

        [Required(ErrorMessage = "Please enter Country")]
        public string EmpCountry { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string EmpPhone { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter Email")]
        public string EmpEmail { get; set; }
    }
}