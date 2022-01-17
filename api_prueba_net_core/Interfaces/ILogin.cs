using api_prueba_net_core.Models.Entidad;
using api_prueba_net_core.Models.EntidadDto;
using System.Threading.Tasks;

namespace api_prueba_net_core.Interfaces
{
    public interface ILogin
    {
        Task<PersonaDTO> postPersonasPorUsuario(LoginDTO loginDTO);
    }
}
