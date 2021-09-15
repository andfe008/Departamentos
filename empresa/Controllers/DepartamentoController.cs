using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using empresa.DatabaseFirts;

namespace empresa.Controllers
{
    public class DepartamentoController : Controller
    {
        private Deptos db = new Deptos();

        // GET: Departamento
        public ActionResult Index()
        {
            return View(db.HR_DEPARTAMENTO.ToList());
        }

        // GET: Departamento/Details/5
        public ActionResult Details(string COD_DEPARTAMENTO)
        {
            if (COD_DEPARTAMENTO == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR_DEPARTAMENTO hR_DEPARTAMENTO = db.HR_DEPARTAMENTO.Where(p => p.COD_DEPARTAMENTO
             == COD_DEPARTAMENTO).FirstOrDefault();
            if (hR_DEPARTAMENTO == null)
            {
                return HttpNotFound();
            }
            return View(hR_DEPARTAMENTO);
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_EMPRESA,COD_DEPARTAMENTO,NOMBRE")] HR_DEPARTAMENTO hR_DEPARTAMENTO)
        {
            if (ModelState.IsValid)
            {
                db.HR_DEPARTAMENTO.Add(hR_DEPARTAMENTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hR_DEPARTAMENTO);
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit(string COD_DEPARTAMENTO)
        {
            if (COD_DEPARTAMENTO == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR_DEPARTAMENTO hR_DEPARTAMENTO = db.HR_DEPARTAMENTO.Where(p=>p.COD_DEPARTAMENTO == COD_DEPARTAMENTO).FirstOrDefault();
            if (hR_DEPARTAMENTO == null)
            {
                return HttpNotFound();
            }
            return View(hR_DEPARTAMENTO);
        }

        // POST: Departamento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_EMPRESA,COD_DEPARTAMENTO,NOMBRE")] HR_DEPARTAMENTO hR_DEPARTAMENTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hR_DEPARTAMENTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hR_DEPARTAMENTO);
        }

        // GET: Departamento/Delete/5
        public ActionResult Delete(string COD_DEPARTAMENTO)
        {
            if (COD_DEPARTAMENTO == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR_DEPARTAMENTO hR_DEPARTAMENTO = db.HR_DEPARTAMENTO.Where(p=>p.COD_DEPARTAMENTO
             ==COD_DEPARTAMENTO).FirstOrDefault();
            if (hR_DEPARTAMENTO == null)
            {
                return HttpNotFound();
            }
            return View(hR_DEPARTAMENTO);
        }

        // POST: Departamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string COD_DEPARTAMENTO)
        {
            HR_DEPARTAMENTO hR_DEPARTAMENTO = db.HR_DEPARTAMENTO.Where(p => p.COD_DEPARTAMENTO
             == COD_DEPARTAMENTO).FirstOrDefault();
            db.HR_DEPARTAMENTO.Remove(hR_DEPARTAMENTO);
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
