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
    public class QuartoCRUDController : Controller
    {
        private Contexto db = new Contexto();

        //
        // GET: /QuartoCRUD/

        public ActionResult Index()
        {
            return View(db.Quartos.ToList());
        }

        //
        // GET: /QuartoCRUD/Details/5

        public ActionResult Details(long id = 0)
        {
            Quarto quarto = db.Quartos.Find(id);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        //
        // GET: /QuartoCRUD/Create

        public ActionResult Create()
        {
            ViewBag.listaStatusQuarto = new SelectList(db.StatusQuartos.ToList(), "INSTANCE", "StDescridao");
            return View();
        }

        //
        // POST: /QuartoCRUD/Create

        [HttpPost]
        public ActionResult Create(Quarto quarto)
        {
            if (ModelState.IsValid)
            {
                db.Quartos.Add(quarto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quarto);
        }

        //
        // GET: /QuartoCRUD/Edit/5

        public ActionResult Edit(long id = 0)
        {
            Quarto quarto = db.Quartos.Find(id);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        //
        // POST: /QuartoCRUD/Edit/5

        [HttpPost]
        public ActionResult Edit(Quarto quarto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quarto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quarto);
        }

        //
        // GET: /QuartoCRUD/Delete/5

        public ActionResult Delete(long id = 0)
        {
            Quarto quarto = db.Quartos.Find(id);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        //
        // POST: /QuartoCRUD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Quarto quarto = db.Quartos.Find(id);
            db.Quartos.Remove(quarto);
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