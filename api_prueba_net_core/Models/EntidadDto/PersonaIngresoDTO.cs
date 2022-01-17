namespace api_prueba_net_core.Models.EntidadDto
{
    public class PersonaIngresoDTO
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public bool? Activo { get; set; }
        public int? IdTipoPersona { get; set; }
    }
}
