using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Educacion.Areas.Admin.Models
{
    public class ViewModelUsuarios
    {
        public string ID { get; set; }

        [Display(Name ="Usuarios")]
        public string NombreUsuario { get; set; }

        

        
    }

    
}
