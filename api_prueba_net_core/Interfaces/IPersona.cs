using api_prueba_net_core.Models.Entidad;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_prueba_net_core.Interfaces
{
    public interface IPersona
    {
        Task<IEnumerable<Persona>> getPersonas();
        Task<Persona> getPersonasPorUsuario(string usuario);
        Task<Persona> postPersonas(Persona persona);
        Task<Persona> putPersonas(Persona persona);
        Task<Persona> deletePersonas(int idPersona);
    }
}
