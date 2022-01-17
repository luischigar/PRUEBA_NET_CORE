using api_prueba_net_core.Models.Entidad;
using api_prueba_net_core.Models.EntidadDto;
using AutoMapper;

namespace api_prueba_net_core.Mappings
{
    public class PersonaMapper:Profile
    {
        public PersonaMapper()
        {
            CreateMap<Persona,PersonaDTO>();
            CreateMap<PersonaDTO, Persona>();
        }
    }
}
