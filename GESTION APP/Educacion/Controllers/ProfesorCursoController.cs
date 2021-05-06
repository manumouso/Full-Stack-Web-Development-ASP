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
    public class ProfesorCursoController : Controller
    {
        private EducacionDBEntities db = new EducacionDBEntities();

        // GET: ProfesorCurso
        public ActionResult Index()
        {
            var profesoresCursos = db.ProfesoresCursos.Include(p => p.Curso).Include(p => p.Profesore);
            return View(profesoresCursos.ToList());
        }

        // GET: ProfesorCurso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfesoresCurso profesoresCurso = db.ProfesoresCursos.Find(id);
            if (profesoresCurso == null)
            {
                return HttpNotFound();
            }
            return View(profesoresCurso);
        }

        // GET: ProfesorCurso/Create
        public ActionResult Create()
        {
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo");
            ViewBag.IdProfesor = new SelectList(db.Profesores, "ID", "Apellido");
            return View();
        }

        // POST: ProfesorCurso/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdProfesor,IdCurso,Funcion")] ProfesoresCurso profesoresCurso)
        {
            if (ModelState.IsValid)
            {
                db.ProfesoresCursos.Add(profesoresCurso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", profesoresCurso.IdCurso);
            ViewBag.IdProfesor = new SelectList(db.Profesores, "ID", "Apellido", profesoresCurso.IdProfesor);
            return View(profesoresCurso);
        }

        // GET: ProfesorCurso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfesoresCurso profesoresCurso = db.ProfesoresCursos.Find(id);
            if (profesoresCurso == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", profesoresCurso.IdCurso);
            ViewBag.IdProfesor = new SelectList(db.Profesores, "ID", "Apellido", profesoresCurso.IdProfesor);
            return View(profesoresCurso);
        }

        // POST: ProfesorCurso/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdProfesor,IdCurso,Funcion")] ProfesoresCurso profesoresCurso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profesoresCurso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", profesoresCurso.IdCurso);
            ViewBag.IdProfesor = new SelectList(db.Profesores, "ID", "Apellido", profesoresCurso.IdProfesor);
            return View(profesoresCurso);
        }

        // GET: ProfesorCurso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfesoresCurso profesoresCurso = db.ProfesoresCursos.Find(id);
            if (profesoresCurso == null)
            {
                return HttpNotFound();
            }
            return View(profesoresCurso);
        }

        // POST: ProfesorCurso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProfesoresCurso profesoresCurso = db.ProfesoresCursos.Find(id);
            db.ProfesoresCursos.Remove(profesoresCurso);
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
