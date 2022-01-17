using api_prueba_net_core.Models.Entidad;
using api_prueba_net_core.Models.EntidadDto;
using AutoMapper;

namespace api_prueba_net_core.Mappings
{
    public class CuentaMapper : Profile
    {
        public CuentaMapper()
        {
            CreateMap<Cuenta, CuentaDTO>();
            CreateMap<CuentaDTO, Cuenta>();
        }
    }
}
