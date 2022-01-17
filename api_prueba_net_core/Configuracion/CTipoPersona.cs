using api_prueba_net_core.Models.Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_prueba_net_core.Configuracion
{
    public class CTipoPersona : IEntityTypeConfiguration<Tipo_Persona>
    {
        public void Configure(EntityTypeBuilder<Tipo_Persona> builder)
        {

            builder.HasKey(e => e.IdTipoPersona);

            builder.ToTable("tipos_persona");

            builder.Property(e => e.IdTipoPersona).HasColumnName("id_tipo_persona");

            //builder.Property(e => e.TipoPersona)
            //    .IsRequired()
            //    .HasColumnName("tipo_persona");
        }
    }
}
