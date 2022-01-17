using System;
using System.Collections.Generic;

namespace api_prueba_net_core.Models.Entidad
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int Saldo { get; set; }
        public int IdCuenta { get; set; }
        //public virtual Cuenta cuenta { get; set; }
    }
}
