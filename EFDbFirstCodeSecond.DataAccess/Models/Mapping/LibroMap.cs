using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFDbFirstCodeSecond.DataAccess.Models.Mapping
{
    public class LibroMap : EntityTypeConfiguration<Libro>
    {
        public LibroMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.titulo)
                .IsRequired();

            this.Property(t => t.estado)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Libro");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.titulo).HasColumnName("titulo");
            this.Property(t => t.estado).HasColumnName("estado");
            this.Property(t => t.progreso).HasColumnName("progreso");
            this.Property(t => t.UsuarioId).HasColumnName("UsuarioId");

            // Relationships
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.Libroes)
                .HasForeignKey(d => d.UsuarioId);

        }
    }
}
