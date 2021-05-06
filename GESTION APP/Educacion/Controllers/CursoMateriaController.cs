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
    public class CursoMateriaController : Controller
    {
        private EducacionDBEntities db = new EducacionDBEntities();

        // GET: CursoMateria
        public ActionResult Index()
        {
            var cursosMaterias = db.CursosMaterias.Include(c => c.Curso).Include(c => c.Materia);
            return View(cursosMaterias.ToList());
        }

        // GET: CursoMateria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursosMateria cursosMateria = db.CursosMaterias.Find(id);
            if (cursosMateria == null)
            {
                return HttpNotFound();
            }
            return View(cursosMateria);
        }

        // GET: CursoMateria/Create
        public ActionResult Create()
        {
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo");
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo");
            return View();
        }

        // POST: CursoMateria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCurso,IdMateria,Funcion")] CursosMateria cursosMateria)
        {
            if (ModelState.IsValid)
            {
                db.CursosMaterias.Add(cursosMateria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", cursosMateria.IdCurso);
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", cursosMateria.IdMateria);
            return View(cursosMateria);
        }

        // GET: CursoMateria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursosMateria cursosMateria = db.CursosMaterias.Find(id);
            if (cursosMateria == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", cursosMateria.IdCurso);
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", cursosMateria.IdMateria);
            return View(cursosMateria);
        }

        // POST: CursoMateria/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCurso,IdMateria,Funcion")] CursosMateria cursosMateria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cursosMateria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCurso = new SelectList(db.Cursos, "ID", "Codigo", cursosMateria.IdCurso);
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", cursosMateria.IdMateria);
            return View(cursosMateria);
        }

        // GET: CursoMateria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursosMateria cursosMateria = db.CursosMaterias.Find(id);
            if (cursosMateria == null)
            {
                return HttpNotFound();
            }
            return View(cursosMateria);
        }

        // POST: CursoMateria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CursosMateria cursosMateria = db.CursosMaterias.Find(id);
            db.CursosMaterias.Remove(cursosMateria);
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
