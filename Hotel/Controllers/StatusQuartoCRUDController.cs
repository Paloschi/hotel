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
    public class StatusQuartoCRUDController : Controller
    {
        private Contexto db = new Contexto();

        //
        // GET: /StatusQuartoCRUD/


        public ActionResult Index()
        {
            return View(db.StatusQuartos.ToList());
        }

        //
        // GET: /StatusQuartoCRUD/Details/5

        public ActionResult Details(long id = 0)
        {
            StatusQuarto statusquarto = db.StatusQuartos.Find(id);
            if (statusquarto == null)
            {
                return HttpNotFound();
            }
            return View(statusquarto);
        }

        //
        // GET: /StatusQuartoCRUD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /StatusQuartoCRUD/Create

        [HttpPost]
        public ActionResult Create(StatusQuarto statusquarto)
        {
            if (ModelState.IsValid)
            {
                db.StatusQuartos.Add(statusquarto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statusquarto);
        }

        //
        // GET: /StatusQuartoCRUD/Edit/5

        public ActionResult Edit(long id = 0)
        {
            StatusQuarto statusquarto = db.StatusQuartos.Find(id);
            if (statusquarto == null)
            {
                return HttpNotFound();
            }
            return View(statusquarto);
        }

        //
        // POST: /StatusQuartoCRUD/Edit/5

        [HttpPost]
        public ActionResult Edit(StatusQuarto statusquarto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusquarto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statusquarto);
        }

        //
        // GET: /StatusQuartoCRUD/Delete/5

        public ActionResult Delete(long id = 0)
        {
            StatusQuarto statusquarto = db.StatusQuartos.Find(id);
            if (statusquarto == null)
            {
                return HttpNotFound();
            }
            return View(statusquarto);
        }

        //
        // POST: /StatusQuartoCRUD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            StatusQuarto statusquarto = db.StatusQuartos.Find(id);
            db.StatusQuartos.Remove(statusquarto);
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