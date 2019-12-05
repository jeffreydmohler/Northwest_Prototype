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

namespace Northwest_Prototype.Controllers
{
    public class WorkOrdersController : Controller
    {
        private NorthwestDevContext db = new NorthwestDevContext();

        // GET: WorkOrders
        //WorkOrders view for Sales Reps
        public ActionResult Index()
        {
            List<WorkOrders> lstWorkOrders = db.workOrders.ToList();
            lstWorkOrders.Sort((x, y) => DateTime.Compare(x.DateDue, y.DateDue));
            return View(lstWorkOrders);
        }

        // GET: WorkOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrders workOrders = db.workOrders.Find(id);
            if (workOrders == null)
            {
                return HttpNotFound();
            }
            return View(workOrders);
        }

        // GET: WorkOrders/Create
        public ActionResult Create()
        {
            ViewBag.Customers = db.customers.ToList();
            ViewBag.Employees = db.employees.ToList();
            ViewBag.Assays = db.assays.ToList();
            ViewBag.Compounds = db.compounds.ToList();

            return View();
        }

        // POST: WorkOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Customer, LT_Number, DateDue,OrderStatus,QuotePrice,Discount,Billed,Paid,Comments,Quantity,DateReceived,ReceivedBy,CompoundWeight_Client,CompoundWeight_Actual,CompoundMass,DateTimeConfirmation,MTD")] WorkOrders workOrders)
        { //[Bind(Include = "WorkOrderID, Customer.CustomerID, DateDue,Status,QuotePrice,Discount,Billed,Paid,Comments,Quantity,DateReceived,ReceivedBy,CompoundWeight_Client,CompoundWeight_Actual,CompoundMass,DateTimeConfirmation,MTD")]
          ///* Customer, Assay, Employee, Compound,

      

            workOrders.Customer = db.customers.Find(workOrders.Customer.CustomerID);
            //workOrders.Assay = db.assays.Find(workOrders.Assay.AssayID);
            //workOrders.Employee = db.employees.Find(workOrders.Employee.EmployeeID);
            //workOrders.Compound = db.compounds.Find(workOrders.Compound.CompoundID);

            if (ModelState.IsValid)
            {
                
                db.workOrders.Add(workOrders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Customers = db.customers.ToList();
            ViewBag.Employees = db.employees.ToList();
            ViewBag.Assays = db.assays.ToList();
            ViewBag.Compounds = db.compounds.ToList();

            return View(workOrders);
        }

        public ActionResult Tests(int iCode)
        {
            //find the work order object that they clicked on
            WorkOrders oWorkOrder = db.workOrders.ToList().Find(x => x.LT_Number == iCode);

            //list of all the reviews
            List<WorkOrders_Tests> lstTests = db.workOrders_Tests.ToList();

            //empty list that will contain all reviews for specific restaurants
            List<WorkOrders_Tests> specTests = new List<WorkOrders_Tests>();

            for (var iCount = 0; iCount < lstTests.Count; iCount++)
            {
                //if the review has same restaurant code as the restaurant clicked on, add that review to specific list
                if (lstTests[iCount].WorkOrders.LT_Number == oWorkOrder.LT_Number)
                {
                    specTests.Add(lstTests[iCount]);
                }
            }

            //pass to models to view with tuple.  the restaurant object for summary info, and specific reviews for that restaurant
            var model = Tuple.Create<WorkOrders, IEnumerable<WorkOrders_Tests>>(oWorkOrder, specTests);

            return View(model);
        }

        public ActionResult AddTest(int iCode)
        {
            
            ViewBag.Employees = db.employees.ToList();
            ViewBag.Tests = db.tests.ToList();
            ViewBag.LT = iCode;

            return View();
        }

        [HttpPost]
        public ActionResult AddTest(WorkOrders_Tests newTest)
        {
            if (ModelState.IsValid)
            {
                db.workOrders_Tests.Add(newTest);
                db.SaveChanges();

                return RedirectToAction("Tests", new { iCode = newTest.WorkOrders.LT_Number });
            }
            else
            {
                ViewBag.Employees = db.employees.ToList();
                ViewBag.Tests = db.tests.ToList();

                return View(newTest);
            }
        }


        // GET: WorkOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrders workOrders = db.workOrders.Find(id);
            if (workOrders == null)
            {
                return HttpNotFound();
            }
            return View(workOrders);
        }

        // POST: WorkOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkOrderID,DateDue,Status,QuotePrice,Discount,Billed,Paid,Comments,Quantity,DateReceived,ReceivedBy,CompoundWeight_Client,CompoundWeight_Actual,CompoundMass,DateTimeConfirmation,MTD")] WorkOrders workOrders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workOrders).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workOrders);
        }

        // GET: WorkOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrders workOrders = db.workOrders.Find(id);
            if (workOrders == null)
            {
                return HttpNotFound();
            }
            return View(workOrders);
        }

        // POST: WorkOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkOrders workOrders = db.workOrders.Find(id);
            db.workOrders.Remove(workOrders);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Quote()
        {
            return View();
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
