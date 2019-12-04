using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Northwest_Prototype.DAL;
using Northwest_Prototype.Models;

namespace Northwest_Prototype.ViewModel
{
    public class TestViewModeModel
    {
        public Assay Assay { get; set; }
        public IEnumerable<SelectListItem> AllTests { get; set; }

        private List<int> _selectedTests;
        public List<int> SelectedTests
        {
            get
            {
                if (_selectedTests == null)
                {
                    _selectedTests = Assay.Tests.Select(m => m.TestID).ToList();
                }
                return _selectedTests;
            }
            set { _selectedTests = value; }
        }
    }
}