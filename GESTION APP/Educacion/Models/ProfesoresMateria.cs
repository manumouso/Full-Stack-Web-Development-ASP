//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Educacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfesoresMateria
    {
        public int IdProfesor { get; set; }
        public int IdMateria { get; set; }
        public string Funcion { get; set; }
    
        public virtual Materia Materia { get; set; }
        public virtual Profesore Profesore { get; set; }
    }
}
