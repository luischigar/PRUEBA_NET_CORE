using api_prueba_net_core.Interfaces;
using api_prueba_net_core.Models.EntidadDto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_prueba_net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private ILogin login;
        private readonly IMapper autoMapper;
        public LoginController(ILogin _login, IMapper _autoMapper)
        {
            login = _login;
            autoMapper = _autoMapper;
        }
        // GET: api/<LoginController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<LoginController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<LoginController>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] LoginDTO value)
        {
            //PersonaDTO personaDto = new PersonaDTO();
            //var resultado = await login.postPersonasPorUsuario(value);
            //personaDto = autoMapper.Map<PersonaDTO>(resultado);
            return Ok(await login.postPersonasPorUsuario(value));
        }

        // PUT api/<LoginController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<LoginController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
