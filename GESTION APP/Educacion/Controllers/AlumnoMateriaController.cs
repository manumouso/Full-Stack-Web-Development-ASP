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
    [Authorize(Roles = ("Alumno"))]
    public class AlumnoMateriaController : Controller
    {
        private EducacionDBEntities db = new EducacionDBEntities();

        // GET: AlumnoMateria
        public ActionResult Index()
        {
            
            var alumnosMaterias = db.AlumnosMaterias.Include(a => a.Alumno).Include(a => a.Materia).Where(a=>a.Alumno.Email==User.Identity.Name);
            return View(alumnosMaterias.ToList());
        }

        // GET: AlumnoMateria/Details/5
       

        // GET: AlumnoMateria/Create
        public ActionResult Create()
        {
            var seleccionado = (from a in db.Alumnos
                               where a.Email == User.Identity.Name
                               select a);
           
            
            ViewBag.IdAlumno = new SelectList(seleccionado, "ID", "Dni");
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Descripcion");
            return View();
        }

        // POST: AlumnoMateria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAlumno,IdMateria,Funcion")] AlumnosMateria alumnosMateria)
        {
            if (ModelState.IsValid)
            {
                db.AlumnosMaterias.Add(alumnosMateria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAlumno = new SelectList(db.Alumnos, "ID", "Dni", alumnosMateria.IdAlumno);
            ViewBag.IdMateria = new SelectList(db.Materias, "ID", "Codigo", alumnosMateria.IdMateria);
            return View(alumnosMateria);
        }

        

        

        // GET: AlumnoMateria/Delete/5
        public ActionResult Delete(int? id,int? id2)
        {
            if (id == null || id2 ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnosMateria alumnosMateria = db.AlumnosMaterias.Find(id,id2);
            if (alumnosMateria == null)
            {
                return HttpNotFound();
            }
            return View(alumnosMateria);
        }

        // POST: AlumnoMateria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, int id2)
        {
            AlumnosMateria alumnosMateria = db.AlumnosMaterias.Find(id,id2);
            db.AlumnosMaterias.Remove(alumnosMateria);
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
