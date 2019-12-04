using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [Required(ErrorMessage = "Please enter Username")]
        [Display(Name = "Username")]
        public string UserID { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

        public virtual Roles Roles { get; set; }

    }
}