using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    [Table("Tests")]
    public class Tests
    {

        [Key]
        [Required]
        public int TestID { get; set; }

        [Required(ErrorMessage = "Please Enter Name for Test")]
        [Display(Name = "Test")]
        public string TestName { get; set; }

        [Required(ErrorMessage = "Please Enter a Description for Test")]
        [Display(Name = "Test Description")]
        public string TestDesc { get; set; }

        [Required(ErrorMessage = "Please Enter the Cost for Test")]
        [Display(Name = "Test Buisness Price")]
        public decimal TestPriceBusi { get; set; }

        [Required(ErrorMessage = "Please Enter a Price for Test")]
        [Display(Name = "Test Customer Price")]
        public decimal TestPriceCust { get; set; }

        public virtual ICollection<AssayToTest> AssayToTests { get; set; }
    }
}