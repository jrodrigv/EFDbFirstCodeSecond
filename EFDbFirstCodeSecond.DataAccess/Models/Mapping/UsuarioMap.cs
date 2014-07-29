using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFDbFirstCodeSecond.DataAccess.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.password)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.nombre)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.nombre).HasColumnName("nombre");

            // Relationships
            this.HasMany(t => t.Usuario1)
                .WithMany(t => t.Usuarios)
                .Map(m =>
                    {
                        m.ToTable("Usuario_Usuario");
                        m.MapLeftKey("UsuarioId_contacto");
                        m.MapRightKey("UsuarioId_principal");
                    });


        }
    }
}
