using api_prueba_net_core.DBContext;
using api_prueba_net_core.Models.Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_prueba_net_core.Configuracion
{
    public class CMovimiento : IEntityTypeConfiguration<Movimiento>
    {
        public void Configure(EntityTypeBuilder<Movimiento> builder)
        {
            builder.HasKey(e => e.IdMovimiento);

            builder.ToTable("movimientos");

            builder.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");

            builder.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");

            builder.Property(e => e.IdCuenta).HasColumnName("id_cuenta");

            builder.Property(e => e.Saldo).HasColumnName("saldo");

            builder.Property(e => e.Tipo)
                .IsRequired()
                .HasColumnName("tipo");

            //builder.HasOne(d => d.cuenta)
            //    .WithMany(p => p.Movimientos)
            //    .HasForeignKey(d => d.IdMovimiento)
            //    .HasConstraintName("FK_movimientos_cuentas");
        }
    }
}
