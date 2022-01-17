using System;
using api_prueba_net_core.Configuracion;
using api_prueba_net_core.Models.Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace api_prueba_net_core.DBContext
{
    public partial class prueba_net_coreContext : DbContext
    {
        public prueba_net_coreContext()
        {
        }

        public prueba_net_coreContext(DbContextOptions<prueba_net_coreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movimiento> Movimientos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Tipo_Persona> TiposPersonas { get; set; }
        public virtual DbSet<Cuenta> Cuentas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CPersona());
            modelBuilder.ApplyConfiguration(new CTipoPersona());
            modelBuilder.ApplyConfiguration(new CCuenta());
            modelBuilder.ApplyConfiguration(new CMovimiento());
        }

    }
}
