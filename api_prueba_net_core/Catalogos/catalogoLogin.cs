using api_prueba_net_core.DBContext;
using api_prueba_net_core.Interfaces;
using api_prueba_net_core.Models.Entidad;
using api_prueba_net_core.Models.EntidadDto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba_net_core.Catalogos
{
    public class catalogoLogin : ILogin
    {
        private readonly prueba_net_coreContext context;
        private readonly IMapper autoMapper;
        public catalogoLogin(prueba_net_coreContext _context, IMapper _autoMapper)
        {
            context = _context;
            autoMapper = _autoMapper;
        }

        public async Task<PersonaDTO> postPersonasPorUsuario(LoginDTO loginDTO)
        {
            PersonaDTO personaDTO = new PersonaDTO();
            //personaDTO = autoMapper.Map<PersonaDTO>(await context.Personas.Include(f => f.tipo_Persona).Where(e => e.Usuario == loginDTO.Usuario).FirstOrDefaultAsync());
            personaDTO = autoMapper.Map<PersonaDTO>(await context.Personas.Where(e => e.Usuario == loginDTO.Usuario).FirstOrDefaultAsync());
            if (personaDTO == null)
            {
                return new PersonaDTO();
            }else if (personaDTO.Clave != loginDTO.Clave)
            {
                return new PersonaDTO();
            }
            return personaDTO;
        }
    }
}
