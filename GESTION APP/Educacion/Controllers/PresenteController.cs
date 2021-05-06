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
    public class PresenteController : Controller
    {
        private EducacionDBEntities db = new EducacionDBEntities();

        // GET: Presente
        public ActionResult Index()
        {
            var presentes = db.Presentes.Include(p => p.Alumno).Include(p => p.Curso).Include(p => p.Materia);
            return View(presentes.ToList());
        }

        // GET: Presente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presente presente = db.Presentes.Find(id);
            if (presente == null)
            {
                return HttpNotFound();
            }
            return View(presente);
        }

        // GET: Presente/Create
        public ActionResult Create()
        {
            ViewBag.IdAlumno = new SelectList(db.Alumnos, "ID", "Dni");
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo");
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo");
            return View();
        }

        // POST: Presente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IdAlumno,IdCurso,IdMateria,Fecha,Hora,Presente1")] Presente presente)
        {
            if (ModelState.IsValid)
            {
                db.Presentes.Add(presente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAlumno = new SelectList(db.Alumnos, "ID", "Dni", presente.IdAlumno);
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", presente.IdCurso);
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", presente.IdMateria);
            return View(presente);
        }

        // GET: Presente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presente presente = db.Presentes.Find(id);
            if (presente == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAlumno = new SelectList(db.Alumnos, "ID", "Dni", presente.IdAlumno);
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", presente.IdCurso);
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", presente.IdMateria);
            return View(presente);
        }

        // POST: Presente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IdAlumno,IdCurso,IdMateria,Fecha,Hora,Presente1")] Presente presente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(presente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAlumno = new SelectList(db.Alumnos, "ID", "Dni", presente.IdAlumno);
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", presente.IdCurso);
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", presente.IdMateria);
            return View(presente);
        }

        // GET: Presente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presente presente = db.Presentes.Find(id);
            if (presente == null)
            {
                return HttpNotFound();
            }
            return View(presente);
        }

        // POST: Presente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Presente presente = db.Presentes.Find(id);
            db.Presentes.Remove(presente);
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
