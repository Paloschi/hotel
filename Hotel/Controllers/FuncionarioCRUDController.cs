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
    public class FuncionarioCRUDController : Controller
    {
        private Contexto db = new Contexto();

        //
        // GET: /FuncionarioCRUD/

        public ActionResult Index()
        {
            return View(db.Funcionarios.ToList());
        }

        //
        // GET: /FuncionarioCRUD/Details/5

        public ActionResult Details(long id = 0)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        //
        // GET: /FuncionarioCRUD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FuncionarioCRUD/Create

        [HttpPost]
        public ActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcionario);
        }

        //
        // GET: /FuncionarioCRUD/Edit/5

        public ActionResult Edit(long id = 0)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        //
        // POST: /FuncionarioCRUD/Edit/5

        [HttpPost]
        public ActionResult Edit(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        //
        // GET: /FuncionarioCRUD/Delete/5

        public ActionResult Delete(long id = 0)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        //
        // POST: /FuncionarioCRUD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            db.Funcionarios.Remove(funcionario);
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