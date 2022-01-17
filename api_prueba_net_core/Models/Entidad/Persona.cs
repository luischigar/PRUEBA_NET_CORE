using System.Collections.Generic;

namespace api_prueba_net_core.Models.Entidad
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public bool? Activo { get; set; }
        public int? IdTipoPersona { get; set; }
        //public virtual Tipo_Persona tipo_Persona { get; set; }
        //public virtual ICollection<Cuenta> Cuentas { get; set; }
    }
}
