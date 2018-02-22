using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _1Assignmnet.Models;

namespace _1Assignmnet.Controllers
{
    public class Table2_Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: Table2_
        public ActionResult Index()
        {
            return View(db.Table2_.ToList());
        }

        // GET: Table2_/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table2_ table2_ = db.Table2_.Find(id);
            if (table2_ == null)
            {
                return HttpNotFound();
            }
            return View(table2_);
        }

        // GET: Table2_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table2_/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "trucks,cost,planes,cranes")] Table2_ table2_)
        {
            if (ModelState.IsValid)
            {
                db.Table2_.Add(table2_);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table2_);
        }

        // GET: Table2_/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table2_ table2_ = db.Table2_.Find(id);
            if (table2_ == null)
            {
                return HttpNotFound();
            }
            return View(table2_);
        }

        // POST: Table2_/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "trucks,cost,planes,cranes")] Table2_ table2_)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table2_).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table2_);
        }

        // GET: Table2_/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table2_ table2_ = db.Table2_.Find(id);
            if (table2_ == null)
            {
                return HttpNotFound();
            }
            return View(table2_);
        }

        // POST: Table2_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table2_ table2_ = db.Table2_.Find(id);
            db.Table2_.Remove(table2_);
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
