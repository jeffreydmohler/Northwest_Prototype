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
            ViewBag.Employees = db.Database.SqlQuery<Employee> (
                "Select EmployeeID, FName + ', ' + LName AS 'FullName'" +
                "From Employee").ToList();
            ViewBag.Assays = db.assays.ToList();
            ViewBag.Compounds = db.compounds.ToList();

            return View();
        }

        // POST: WorkOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkOrderID,DateDue,Status,QuotePrice,Discount,Billed,Paid,Comments,Quantity,DateReceived,ReceivedBy,CompoundWeight_Client,CompoundWeight_Actual,CompoundMass,DateTimeConfirmation,MTD")] WorkOrders workOrders)
        {
            if (ModelState.IsValid)
            {
                db.workOrders.Add(workOrders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workOrders);
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
