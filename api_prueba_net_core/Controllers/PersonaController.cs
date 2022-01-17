using api_prueba_net_core.Interfaces;
using api_prueba_net_core.Models.Entidad;
using api_prueba_net_core.Models.EntidadDto;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace api_prueba_net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private IPersona persona;
        private readonly IMapper autoMapper;
        public PersonaController(IPersona _persona, IMapper _autoMapper)
        {
            persona = _persona;
            autoMapper = _autoMapper;
        }

        //[HttpGet]
        //public async Task<IActionResult> getPersonas()
        //{
        //    return Ok(await persona.getPersonas());
        //}
        [HttpGet]
        public async Task<IActionResult> getPersonasPorUsuario(string usuario)
        {
            PersonaDTO personaDto = new PersonaDTO();
            var resultado = await persona.getPersonasPorUsuario(usuario);
            personaDto = autoMapper.Map<PersonaDTO>(resultado);
            return Ok(personaDto);
        }

        // POST api/<PersonaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Persona value)
        {
            if (value == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(await persona.postPersonas(value));
        }

        // PUT api/<PersonaController>
        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] Persona value)
        {
            if (value == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(await persona.putPersonas(value));
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return Ok(await persona.deletePersonas(id));
        }
    }
}
