using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EFDbFirstCodeSecond.DataAccess.Models.Mapping;

namespace EFDbFirstCodeSecond.DataAccess.Models
{
    public partial class EFDbFirstCodeSecondContext : DbContext
    {
        static EFDbFirstCodeSecondContext()
        {
            Database.SetInitializer<EFDbFirstCodeSecondContext>(null);
        }

        public EFDbFirstCodeSecondContext()
            : base("Name=EFDbFirstCodeSecondContext")
        {
        }

        public DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public DbSet<Libro> Libroes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new C__RefactorLogMap());
            modelBuilder.Configurations.Add(new LibroMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
