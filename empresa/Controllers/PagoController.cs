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
    public class PagoController : Controller
    {
        private Deptos db = new Deptos();

        // GET: Pago
        public ActionResult Index()
        {
            return View(db.HR_PAGO.ToList());
        }

        // GET: Pago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR_PAGO hR_PAGO = db.HR_PAGO.Find(id);
            if (hR_PAGO == null)
            {
                return HttpNotFound();
            }
            return View(hR_PAGO);
        }

        // GET: Pago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO,COD_EMPRESA,COD_RUBRO_PAGO,RESULTADO,FECHA_PAGO")] HR_PAGO hR_PAGO)
        {
            if (ModelState.IsValid)
            {
                db.HR_PAGO.Add(hR_PAGO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hR_PAGO);
        }

        // GET: Pago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR_PAGO hR_PAGO = db.HR_PAGO.Find(id);
            if (hR_PAGO == null)
            {
                return HttpNotFound();
            }
            return View(hR_PAGO);
        }

        // POST: Pago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO,COD_EMPRESA,COD_RUBRO_PAGO,RESULTADO,FECHA_PAGO")] HR_PAGO hR_PAGO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hR_PAGO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hR_PAGO);
        }

        // GET: Pago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR_PAGO hR_PAGO = db.HR_PAGO.Find(id);
            if (hR_PAGO == null)
            {
                return HttpNotFound();
            }
            return View(hR_PAGO);
        }

        // POST: Pago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HR_PAGO hR_PAGO = db.HR_PAGO.Find(id);
            db.HR_PAGO.Remove(hR_PAGO);
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
