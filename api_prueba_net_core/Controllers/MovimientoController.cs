using api_prueba_net_core.Interfaces;
using api_prueba_net_core.Models.Entidad;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_prueba_net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientoController : ControllerBase
    {
        private IMovimiento movimiento;
        public MovimientoController(IMovimiento _movimiento)
        {
            movimiento = _movimiento;
        }
        // GET: api/<MovimientoController>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await movimiento.getMovimiento());
        }

        // GET api/<MovimientoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<MovimientoController>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Movimiento value)
        {
            if (value == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(await movimiento.postMovimiento(value));
        }

        // PUT api/<MovimientoController>
        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] Movimiento value)
        {
            if (value == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(await movimiento.putMovimiento(value));
        }

        // DELETE api/<MovimientoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return Ok(await movimiento.deleteMovimiento(id));
        }
    }
}
