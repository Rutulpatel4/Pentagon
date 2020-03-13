using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pentagon.Models;

namespace Pentagon.Controllers
{
    public class KeysController : Controller
    {
        private DbModel db = new DbModel();

        // GET: Keys
        public ActionResult Index()
        {
            var keys = db.keys.Include(k => k.vehicle);
            return View(keys.ToList());
        }

        // GET: Keys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            key key = db.keys.Find(id);
            if (key == null)
            {
                return HttpNotFound();
            }
            return View(key);
        }

        // GET: Keys/Create
        public ActionResult Create()
        {
            ViewBag.vehicleId = new SelectList(db.vehicles, "vehicleId", "vehicleType");
            return View();
        }

        // POST: Keys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "keyId,keyTrackingNumber,vehicleId")] key key)
        {
            if (ModelState.IsValid)
            {
                db.keys.Add(key);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.vehicleId = new SelectList(db.vehicles, "vehicleId", "vehicleType", key.vehicleId);
            return View(key);
        }

        // GET: Keys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            key key = db.keys.Find(id);
            if (key == null)
            {
                return HttpNotFound();
            }
            ViewBag.vehicleId = new SelectList(db.vehicles, "vehicleId", "vehicleType", key.vehicleId);
            return View(key);
        }

        // POST: Keys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "keyId,keyTrackingNumber,vehicleId")] key key)
        {
            if (ModelState.IsValid)
            {
                db.Entry(key).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.vehicleId = new SelectList(db.vehicles, "vehicleId", "vehicleType", key.vehicleId);
            return View(key);
        }

        // GET: Keys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            key key = db.keys.Find(id);
            if (key == null)
            {
                return HttpNotFound();
            }
            return View(key);
        }

        // POST: Keys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            key key = db.keys.Find(id);
            db.keys.Remove(key);
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
