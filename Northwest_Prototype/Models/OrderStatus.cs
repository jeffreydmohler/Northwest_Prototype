using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    public class OrderStatus
    {
        [Key]
        [Required]
        public int OrderStatusCode { get; set; }

        [Required]
        public string OrderStatusTitle { get; set; }

        [Required]
        public string OrderStatusDesc { get; set; }

    }
}