using api_prueba_net_core.Models.Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_prueba_net_core.Configuracion
{
    public class CPersona : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(e => e.IdPersona);

            builder.ToTable("personas");

            builder.Property(e => e.IdPersona).HasColumnName("id_persona");

            builder.Property(e => e.Activo).HasColumnName("activo");

            builder.Property(e => e.Apellidos).HasColumnName("apellidos");

            builder.Property(e => e.Clave).HasColumnName("clave");

            builder.Property(e => e.IdTipoPersona).HasColumnName("id_tipo_persona");

            builder.Property(e => e.Nombres).HasColumnName("nombres");

            builder.Property(e => e.Usuario).HasColumnName("usuario");

            //builder.HasOne(d => d.tipo_Persona)
            //    .WithMany(p => p.Personas)
            //    .HasForeignKey(d => d.IdTipoPersona)
            //    .HasConstraintName("FK_personas_tipos_persona");
        }
    }
}
