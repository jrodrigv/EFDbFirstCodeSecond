using System;
using System.Collections.Generic;

namespace EFDbFirstCodeSecond.DataAccess.Models
{
    public partial class Libro
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public string estado { get; set; }
        public int progreso { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
