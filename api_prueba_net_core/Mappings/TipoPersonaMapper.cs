using api_prueba_net_core.Models.Entidad;
using api_prueba_net_core.Models.EntidadDto;
using AutoMapper;

namespace api_prueba_net_core.Mappings
{
    public class TipoPersonaMapper: Profile
    {
        public TipoPersonaMapper()
        {
            CreateMap<Tipo_Persona, TipoPersonaDTO>();
            CreateMap<TipoPersonaDTO, Tipo_Persona>();
        }
    }
}
