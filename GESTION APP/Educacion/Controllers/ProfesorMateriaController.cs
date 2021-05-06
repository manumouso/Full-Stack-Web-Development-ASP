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
    public class ProfesorMateriaController : Controller
    {
        private EducacionDBEntities db = new EducacionDBEntities();

        // GET: ProfesorMateria
        public ActionResult Index()
        {
            var profesoresMaterias = db.ProfesoresMaterias.Include(p => p.Materia).Include(p => p.Profesore);
            return View(profesoresMaterias.ToList());
        }

        // GET: ProfesorMateria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfesoresMateria profesoresMateria = db.ProfesoresMaterias.Find(id);
            if (profesoresMateria == null)
            {
                return HttpNotFound();
            }
            return View(profesoresMateria);
        }

        // GET: ProfesorMateria/Create
        public ActionResult Create()
        {
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo");
            ViewBag.IdProfesor = new SelectList(db.Profesores, "ID", "Apellido");
            return View();
        }

        // POST: ProfesorMateria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdProfesor,IdMateria,Funcion")] ProfesoresMateria profesoresMateria)
        {
            if (ModelState.IsValid)
            {
                db.ProfesoresMaterias.Add(profesoresMateria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", profesoresMateria.IdMateria);
            ViewBag.IdProfesor = new SelectList(db.Profesores, "ID", "Apellido", profesoresMateria.IdProfesor);
            return View(profesoresMateria);
        }

        // GET: ProfesorMateria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfesoresMateria profesoresMateria = db.ProfesoresMaterias.Find(id);
            if (profesoresMateria == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", profesoresMateria.IdMateria);
            ViewBag.IdProfesor = new SelectList(db.Profesores, "ID", "Apellido", profesoresMateria.IdProfesor);
            return View(profesoresMateria);
        }

        // POST: ProfesorMateria/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdProfesor,IdMateria,Funcion")] ProfesoresMateria profesoresMateria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profesoresMateria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", profesoresMateria.IdMateria);
            ViewBag.IdProfesor = new SelectList(db.Profesores, "ID", "Apellido", profesoresMateria.IdProfesor);
            return View(profesoresMateria);
        }

        // GET: ProfesorMateria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfesoresMateria profesoresMateria = db.ProfesoresMaterias.Find(id);
            if (profesoresMateria == null)
            {
                return HttpNotFound();
            }
            return View(profesoresMateria);
        }

        // POST: ProfesorMateria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProfesoresMateria profesoresMateria = db.ProfesoresMaterias.Find(id);
            db.ProfesoresMaterias.Remove(profesoresMateria);
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
