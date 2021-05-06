using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Common;
using System.Net;
using Educacion.Areas.Admin.Models;

namespace Educacion.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AdminController : Controller
    {
        private SeguridadAppEntities contexto = new SeguridadAppEntities();
                
        // GET: Admin/Admin
        public ActionResult Index(string mensaje)
        {
            var usuarios = from u in contexto.AspNetUsers
                           orderby u.UserName       
                           select new ViewModelUsuarios
                           {
                               ID = u.Id,
                               NombreUsuario = u.UserName                             
                           };
            
            var a = GetRoles();
            ViewBag.Roles = new SelectList(a, "Id", "Name",2);

            ViewBag.Mensaje = mensaje;

            return View(usuarios.ToList());
        }
      
        public ActionResult AsignarRoles(string id,string nombre,string rol)
        {
            AspNetUserRole aspNetUserRole = contexto.AspNetUserRoles.Find(id, rol);
            if(aspNetUserRole == null)
            {
                contexto.AltaRoles(id, nombre, rol);
            }
                       
            return RedirectToAction("Index");
        }
        public List<AspNetRole> GetRoles()
        {
            var roles= (from r in contexto.AspNetRoles
                       select r).ToList();

            return roles;
            
        }
        public List<AspNetUser> GetUsuarios()
        {
            var usuarios = (from u in contexto.AspNetUsers
                         select u).ToList();

            return usuarios;

        }

        // GET: Admin/Delete/5
        public ActionResult Delete(string id2)
        {
            if (id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetUser aspNetUser = contexto.AspNetUsers.Find(id2);
            if (aspNetUser == null)
            {
                return HttpNotFound();
            }
            return View(aspNetUser);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id2)
        {
            var rolID = "1";
            var usuariosroles = contexto.AspNetUserRoles.ToList();
            var cantidadAdministradores = 0;
            AspNetUserRole aspNetUserRole = contexto.AspNetUserRoles.Find(id2, rolID);

            foreach (var a in usuariosroles)
            {
                if (a.RoleId == rolID)
                {
                    cantidadAdministradores++;
                }
            }
            
            if (cantidadAdministradores == 1 && aspNetUserRole!=null)
            {
                var msg = "*No se puede eliminar al unico administrador";
                return RedirectToAction("Index", new { mensaje = msg });
            }
            else
            {
                AspNetUser aspNetUser = contexto.AspNetUsers.Find(id2);
                contexto.AspNetUsers.Remove(aspNetUser);
                contexto.SaveChanges();
                
                return RedirectToAction("Index");
            }
                                          
                      
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                contexto.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}



