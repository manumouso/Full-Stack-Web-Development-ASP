using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Educacion.Models;

namespace Educacion.Controllers
{
    [Authorize(Roles =("Profesor"))]
    public class ProfesorController : Controller
    {
        private EducacionDBEntities db = new EducacionDBEntities();

        // GET: Profesor
        public ActionResult Index()
        {
            return View(db.Profesores.ToList());
        }

        // GET: Profesor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesore profesore = db.Profesores.Find(id);
            if (profesore == null)
            {
                return HttpNotFound();
            }
            return View(profesore);
        }

        // GET: Profesor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profesor/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Apellido,Nombre,Email")] Profesore profesore)
        {
            if (ModelState.IsValid)
            {
                db.Profesores.Add(profesore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profesore);
        }

        // GET: Profesor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesore profesore = db.Profesores.Find(id);
            if (profesore == null)
            {
                return HttpNotFound();
            }
            return View(profesore);
        }

        // POST: Profesor/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Apellido,Nombre,Email")] Profesore profesore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profesore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profesore);
        }

        // GET: Profesor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesore profesore = db.Profesores.Find(id);
            if (profesore == null)
            {
                return HttpNotFound();
            }
            return View(profesore);
        }

        // POST: Profesor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profesore profesore = db.Profesores.Find(id);
            db.Profesores.Remove(profesore);
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
