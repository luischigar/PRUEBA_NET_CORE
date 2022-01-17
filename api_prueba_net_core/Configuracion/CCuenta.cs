using api_prueba_net_core.Models.Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_prueba_net_core.Configuracion
{
    public class CCuenta : IEntityTypeConfiguration<Cuenta>
    {
        public void Configure(EntityTypeBuilder<Cuenta> builder)
        {
            builder.HasKey(e => e.IdCuenta);

            builder.ToTable("cuentas");

            builder.Property(e => e.IdCuenta).HasColumnName("id_cuenta");

            builder.Property(e => e.IdPersona).HasColumnName("id_persona");

            builder.Property(e => e.Numero).HasColumnName("numero");

            builder.Property(e => e.Saldo).HasColumnName("saldo");

            //builder.HasOne(d => d.persona)
            //    .WithMany(p => p.Cuentas)
            //    .HasForeignKey(d => d.IdCuenta)
            //    .HasConstraintName("FK_cuentas_personas");
        }
    }
}
