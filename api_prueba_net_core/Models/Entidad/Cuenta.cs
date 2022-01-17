using System.Collections.Generic;

namespace api_prueba_net_core.Models.Entidad
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public int Numero { get; set; }
        public int Saldo { get; set; }
        public int IdPersona { get; set; }
        //public virtual Persona persona { get; set; }
        //public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}
