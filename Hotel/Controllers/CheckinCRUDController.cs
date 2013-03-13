using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models.poco;
using Hotel.Models;

namespace Hotel.Controllers
{
    public class CheckinCRUDController : Controller
    {
        private Contexto db = new Contexto();

        //
        // GET: /CheckinCRUD/

        public ActionResult Index()
        {
            return View(db.Checkins.ToList());
        }

        //
        // GET: /CheckinCRUD/Details/5

        public ActionResult Details(long id = 0)
        {
            Checkin checkin = db.Checkins.Find(id);
            if (checkin == null)
            {
                return HttpNotFound();
            }
            return View(checkin);
        }

        //
        // GET: /CheckinCRUD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CheckinCRUD/Create

        [HttpPost]
        public ActionResult Create(Checkin checkin)
        {
            if (ModelState.IsValid)
            {
                db.Checkins.Add(checkin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(checkin);
        }

        //
        // GET: /CheckinCRUD/Edit/5

        public ActionResult Edit(long id = 0)
        {
            Checkin checkin = db.Checkins.Find(id);
            if (checkin == null)
            {
                return HttpNotFound();
            }
            return View(checkin);
        }

        //
        // POST: /CheckinCRUD/Edit/5

        [HttpPost]
        public ActionResult Edit(Checkin checkin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(checkin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(checkin);
        }

        //
        // GET: /CheckinCRUD/Delete/5

        public ActionResult Delete(long id = 0)
        {
            Checkin checkin = db.Checkins.Find(id);
            if (checkin == null)
            {
                return HttpNotFound();
            }
            return View(checkin);
        }

        //
        // POST: /CheckinCRUD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Checkin checkin = db.Checkins.Find(id);
            db.Checkins.Remove(checkin);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}