using Northwest_Prototype.DAL;
using Northwest_Prototype.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Northwest_Prototype.Controllers
{
    public class QuotesController : Controller
    {
        private NorthwestDevContext db = new NorthwestDevContext();

        // GET: Assays
        public ActionResult Index()
        {
            return View(db.assays.ToList());
        }

        // GET: Assays/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay assay = db.assays.Find(id);
            if (assay == null)
            {
                return HttpNotFound();
            }
            var Results = from b in db.tests
                          select new
                          {
                              b.TestID,
                              b.TestName,
                              b.TestPriceCust,

                              Checked = ((from ab in db.assayToTests
                                          where (ab.AssayID == id) & (ab.TestID == b.TestID)
                                          select ab).Count() > 0)


                          };
            var MyViewModel = new AssayViewModel();
            MyViewModel.AssayID = id;
            MyViewModel.AssayName = assay.AssayName;
            MyViewModel.AssayProtocol = assay.AssayProtocol;
            MyViewModel.EstDayDuration = assay.EstDayDuration;

            var MyCheckBoxList = new List<CheckBoxViewModel>();
            decimal TotalPrice = 0;
            foreach (var item in Results)
            {
                MyCheckBoxList.Add(new CheckBoxViewModel { Id = item.TestID, Name = item.TestName, Checked = item.Checked, Price = item.TestPriceCust });
                if (item.Checked)
                {
                    TotalPrice = TotalPrice + (item.TestPriceCust + (MyViewModel.EstDayDuration * (8 * 40)));
                }
            }

            MyViewModel.Tests = MyCheckBoxList;
            MyViewModel.TotalPrice = TotalPrice;
            return View(MyViewModel);
        }

        // GET: Assays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssayID,AssayName,AssayProtocol,EstDayDuration")] Assay assay)
        {
            if (ModelState.IsValid)
            {
                db.assays.Add(assay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assay);
        }

        // GET: Assays/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay assay = db.assays.Find(id);
            if (assay == null)
            {
                return HttpNotFound();
            }

            var Results = from b in db.tests
                          select new
                          {
                              b.TestID,
                              b.TestName,

                              Checked = ((from ab in db.assayToTests
                                          where (ab.AssayID == id) & (ab.TestID == b.TestID)
                                          select ab).Count() > 0)


                          };
            var MyViewModel = new AssayViewModel();
            MyViewModel.AssayID = id;
            MyViewModel.AssayName = assay.AssayName;
            MyViewModel.AssayProtocol = assay.AssayProtocol;
            MyViewModel.EstDayDuration = assay.EstDayDuration;

            var MyCheckBoxList = new List<CheckBoxViewModel>();

            foreach (var item in Results)
            {
                MyCheckBoxList.Add(new CheckBoxViewModel { Id = item.TestID, Name = item.TestName, Checked = item.Checked });
            }

            MyViewModel.Tests = MyCheckBoxList;

            return View(MyViewModel);
        }

        // POST: Assays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AssayViewModel assay)
        {
            if (ModelState.IsValid)
            {
                var MyAssay = db.assays.Find(assay.AssayID);


                MyAssay.AssayName = assay.AssayName;
                MyAssay.AssayProtocol = assay.AssayProtocol;
                MyAssay.EstDayDuration = assay.EstDayDuration;

                foreach (var item in db.assayToTests)
                {
                    if (item.AssayID == assay.AssayID)
                    {
                        db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    }
                }

                foreach (var item in assay.Tests)
                {
                    if (item.Checked)
                    {

                        db.assayToTests.Add(new AssayToTest() { AssayID = assay.AssayID, TestID = item.Id });
                    }
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assay);
        }

        // GET: Assays/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay assay = db.assays.Find(id);
            if (assay == null)
            {
                return HttpNotFound();
            }
            return View(assay);
        }

        // POST: Assays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Assay assay = db.assays.Find(id);
            db.assays.Remove(assay);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

