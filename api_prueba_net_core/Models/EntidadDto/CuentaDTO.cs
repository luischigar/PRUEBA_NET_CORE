namespace api_prueba_net_core.Models.EntidadDto
{
    public class CuentaDTO
    {
        public int IdCuenta { get; set; }
        public int Numero { get; set; }
        public int Saldo { get; set; }
        public int IdPersona { get; set; }
        public PersonaDTO persona { get; set; }
    }
}
