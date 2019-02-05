using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Event.Models;

namespace Event.Controllers
{
    public class Event_DetailController : Controller
    {
        //initializing the DbModel
        private DbModel db = new DbModel();

        // GET: Event_Detail
        public ActionResult Index()
        {
            return View(db.Event_Details.ToList());
        }

        // GET: Event_Detail/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event_Detail event_Detail = db.Event_Details.Find(id);
            if (event_Detail == null)
            {
                return HttpNotFound();
            }
            return View(event_Detail);
        }

        // GET: Event_Detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event_Detail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Number,Starts,Ends")] Event_Detail event_Detail)
        {
            if (ModelState.IsValid)
            {
                db.Event_Details.Add(event_Detail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(event_Detail);
        }

        // GET: Event_Detail/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event_Detail event_Detail = db.Event_Details.Find(id);
            if (event_Detail == null)
            {
                return HttpNotFound();
            }
            return View(event_Detail);
        }

        // POST: Event_Detail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Number,Starts,Ends")] Event_Detail event_Detail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(event_Detail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(event_Detail);
        }

        // GET: Event_Detail/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event_Detail event_Detail = db.Event_Details.Find(id);
            if (event_Detail == null)
            {
                return HttpNotFound();
            }
            return View(event_Detail);
        }

        // POST: Event_Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Event_Detail event_Detail = db.Event_Details.Find(id);
            db.Event_Details.Remove(event_Detail);
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
