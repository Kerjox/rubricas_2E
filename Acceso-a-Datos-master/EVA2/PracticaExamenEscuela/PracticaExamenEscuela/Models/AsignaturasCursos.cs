//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticaExamenEscuela.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AsignaturasCursos
    {
        public int ID { get; set; }
        public Nullable<int> AsignaturaID { get; set; }
        public Nullable<int> CursoID { get; set; }
    
        public virtual Asignaturas Asignaturas { get; set; }
        public virtual Cursos Cursos { get; set; }
    }
}
