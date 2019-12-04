using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwest_Prototype.Models
{
    [Table("Roles")]
	public class Roles
	{
        [Required]
        [Key]
        public int RoleID { get; set; }

        [Display(Name = "Role")]
        [Required]
        [StringLength(20)]
        public string RoleTitle { get; set; }
    }
}