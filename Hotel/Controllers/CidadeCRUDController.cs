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
    public class CidadeCRUDController : Controller
    {
        private Contexto db = new Contexto();

        //
        // GET: /CidadeCRUD/

        public ActionResult Index()
        {
            return View(db.Cidades.ToList());
        }

        //
        // GET: /CidadeCRUD/Details/5

        public ActionResult Details(long id = 0)
        {
            Cidade cidade = db.Cidades.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        //
        // GET: /CidadeCRUD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CidadeCRUD/Create

        [HttpPost]
        public ActionResult Create(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Cidades.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cidade);
        }

        //
        // GET: /CidadeCRUD/Edit/5

        public ActionResult Edit(long id = 0)
        {
            Cidade cidade = db.Cidades.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        //
        // POST: /CidadeCRUD/Edit/5

        [HttpPost]
        public ActionResult Edit(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cidade);
        }

        //
        // GET: /CidadeCRUD/Delete/5

        public ActionResult Delete(long id = 0)
        {
            Cidade cidade = db.Cidades.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        //
        // POST: /CidadeCRUD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Cidade cidade = db.Cidades.Find(id);
            db.Cidades.Remove(cidade);
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