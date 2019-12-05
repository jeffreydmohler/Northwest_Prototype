using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwest_Prototype.Models
{
    public class AssayViewModel
    {
        public string AssayID { get; set; }
        public string AssayName { get; set; }
        public string AssayProtocol { get; set; }
        public int EstDayDuration { get; set; }
        public decimal TotalPrice { get; set; }

        public List<CheckBoxViewModel> Tests { get; set; }
    }
}