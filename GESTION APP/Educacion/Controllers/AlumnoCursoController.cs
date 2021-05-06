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
    [Authorize(Roles =("Alumno"))]
    public class AlumnoCursoController : Controller
    {
       
        private EducacionDBEntities db = new EducacionDBEntities();

        // GET: AlumnoCurso
        public ActionResult Index()
        {
            var alumnosCursos = db.AlumnosCursos.Include(a => a.Alumno).Include(a => a.Curso);
            return View(alumnosCursos.ToList());
        }

        // GET: AlumnoCurso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnosCurso alumnosCurso = db.AlumnosCursos.Find(id);
            if (alumnosCurso == null)
            {
                return HttpNotFound();
            }
            return View(alumnosCurso);
        }

        // GET: AlumnoCurso/Create
        public ActionResult Create()
        {
            ViewBag.IdAlumno = new SelectList(db.Alumnos, "ID", "Dni");
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo");
            return View();
        }

        // POST: AlumnoCurso/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAlumno,IdCurso,Funcion")] AlumnosCurso alumnosCurso)
        {
            if (ModelState.IsValid)
            {
                db.AlumnosCursos.Add(alumnosCurso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAlumno = new SelectList(db.Alumnos, "ID", "Dni", alumnosCurso.IdAlumno);
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", alumnosCurso.IdCurso);
            return View(alumnosCurso);
        }

        // GET: AlumnoCurso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnosCurso alumnosCurso = db.AlumnosCursos.Find(id);
            if (alumnosCurso == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAlumno = new SelectList(db.Alumnos, "ID", "Dni", alumnosCurso.IdAlumno);
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", alumnosCurso.IdCurso);
            return View(alumnosCurso);
        }

        // POST: AlumnoCurso/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAlumno,IdCurso,Funcion")] AlumnosCurso alumnosCurso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumnosCurso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAlumno = new SelectList(db.Alumnos, "ID", "Dni", alumnosCurso.IdAlumno);
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", alumnosCurso.IdCurso);
            return View(alumnosCurso);
        }

        // GET: AlumnoCurso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnosCurso alumnosCurso = db.AlumnosCursos.Find(id);
            if (alumnosCurso == null)
            {
                return HttpNotFound();
            }
            return View(alumnosCurso);
        }

        // POST: AlumnoCurso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AlumnosCurso alumnosCurso = db.AlumnosCursos.Find(id);
            db.AlumnosCursos.Remove(alumnosCurso);
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
