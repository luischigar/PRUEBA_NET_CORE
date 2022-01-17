using api_prueba_net_core.Interfaces;
using api_prueba_net_core.Models.Entidad;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_prueba_net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        private ICuenta cuenta;
        public CuentaController(ICuenta _cuenta)
        {
            cuenta = _cuenta;
        }
        // GET: api/<CuentaController>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await cuenta.getCuentas());
        }

        // GET api/<CuentaController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<CuentaController>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Cuenta value)
        {
            if (value == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(await cuenta.postCuentas(value));
        }

        // PUT api/<CuentaController>
        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] Cuenta value)
        {
            if (value == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(await cuenta.putCuenta(value));
        }

        // DELETE api/<CuentaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return Ok(await cuenta.deleteCuenta(id));
        }
    }
}
