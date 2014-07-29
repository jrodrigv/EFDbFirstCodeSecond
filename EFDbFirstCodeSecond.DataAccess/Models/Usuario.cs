using System;
using System.Collections.Generic;

namespace EFDbFirstCodeSecond.DataAccess.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            this.Libroes = new List<Libro>();
            this.Usuario1 = new List<Usuario>();
            this.Usuarios = new List<Usuario>();
        }

        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public virtual ICollection<Libro> Libroes { get; set; }
        public virtual ICollection<Usuario> Usuario1 { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
