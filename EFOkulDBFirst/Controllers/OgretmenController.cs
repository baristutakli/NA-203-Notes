using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EFOkulDBFirst.Models;

namespace EFOkulDBFirst.Controllers
{
    public class OgretmenController : Controller
    {
        private OkulContext db = new OkulContext();

        // GET: Ogretmen
        public ActionResult Index()
        {
            return View(db.Ogretmen.ToList());
        }

        // GET: Ogretmen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogretmen ogretmen = db.Ogretmen.Find(id);
            if (ogretmen == null)
            {
                return HttpNotFound();
            }
            return View(ogretmen);
        }

        // GET: Ogretmen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ogretmen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Classroom")] Ogretmen ogretmen)
        {
            if (ModelState.IsValid)
            {
                db.Ogretmen.Add(ogretmen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ogretmen);
        }

        // GET: Ogretmen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogretmen ogretmen = db.Ogretmen.Find(id);
            if (ogretmen == null)
            {
                return HttpNotFound();
            }
            return View(ogretmen);
        }

        // POST: Ogretmen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Classroom")] Ogretmen ogretmen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ogretmen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ogretmen);
        }

        // GET: Ogretmen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogretmen ogretmen = db.Ogretmen.Find(id);
            if (ogretmen == null)
            {
                return HttpNotFound();
            }
            return View(ogretmen);
        }

        // POST: Ogretmen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ogretmen ogretmen = db.Ogretmen.Find(id);
            db.Ogretmen.Remove(ogretmen);
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
