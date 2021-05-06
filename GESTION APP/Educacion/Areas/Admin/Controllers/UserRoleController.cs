using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Educacion.Areas.Admin.Models;

namespace Educacion.Areas.Admin.Controllers
{
    [Authorize(Roles ="Administrador")]
    public class UserRoleController : Controller
    {
        private SeguridadAppEntities db = new SeguridadAppEntities();

        // GET: Admin/UserRole
        public ActionResult Index(string mensaje)
        {
           var aspNetUserRoles = db.AspNetUserRoles.Include(a => a.AspNetRole).Include(a => a.AspNetUser);
            ViewBag.Mensaje = mensaje;
            return View(aspNetUserRoles.ToList());
        }
    

        // GET: Admin/UserRole/Delete/5
        public ActionResult Delete(string id, string id2)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetUserRole aspNetUserRole = db.AspNetUserRoles.Find(id,id2);
            if (aspNetUserRole == null)
            {
                return HttpNotFound();
            }
            return View(aspNetUserRole);
        }
       
        // POST: Admin/UserRole/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id, string id2)
        {
            var rolID = "1";
            var usuariosroles = db.AspNetUserRoles.ToList();
            var cantidadAdministradores = 0;

            foreach (var a in usuariosroles)
            {
                if (a.RoleId == rolID)
                {
                    cantidadAdministradores++;
                }
            }
            if (cantidadAdministradores == 1 && id2=="1")
            {
                var msg = "*No se puede eliminar la unica relacion usuario-administrador";
                return RedirectToAction("Index", new { mensaje = msg });
            }
            else
            {
                AspNetUserRole aspNetUserRole = db.AspNetUserRoles.Find(id, id2);
                db.AspNetUserRoles.Remove(aspNetUserRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
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
