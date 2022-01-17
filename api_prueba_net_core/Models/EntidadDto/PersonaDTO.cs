namespace api_prueba_net_core.Models.EntidadDto
{
    public class PersonaDTO
    {
        public int IdPersona { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public bool? Activo { get; set; }
        public int? IdTipoPersona { get; set; }
        public TipoPersonaDTO tipo_Persona { get; set; }
    }
}
