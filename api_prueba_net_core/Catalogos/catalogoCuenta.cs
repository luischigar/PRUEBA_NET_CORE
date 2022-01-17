using api_prueba_net_core.DBContext;
using api_prueba_net_core.Interfaces;
using api_prueba_net_core.Models.Entidad;
using api_prueba_net_core.Models.EntidadDto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba_net_core.Catalogos
{
    public class catalogoCuenta : ICuenta
    {
        private readonly prueba_net_coreContext context;
        private readonly IMapper autoMapper;
        public catalogoCuenta(prueba_net_coreContext _context, IMapper _autoMapper)
        {
            context = _context;
            autoMapper = _autoMapper;
        }
        public async Task<IEnumerable<CuentaDTO>> getCuentas()
        {
            List<CuentaDTO> lCuentaDTO = new List<CuentaDTO>();
            List<Cuenta> lCuenta = await context.Cuentas.ToListAsync();
            foreach (var item in lCuenta)
            {
                lCuentaDTO.Add(autoMapper.Map<CuentaDTO>(item));
            }
            return lCuentaDTO;
        }

        public async Task<Cuenta> postCuentas(Cuenta cuenta)
        {
            Cuenta oCuentaa = new Cuenta();
            await context.Cuentas.AddAsync(cuenta);
            await context.SaveChangesAsync();
            return oCuentaa;
        }

        public async Task<Cuenta> putCuenta(Cuenta cuenta)
        {
            Cuenta oCuenta = new Cuenta();

            context.Entry(cuenta).State = EntityState.Modified;
            await context.SaveChangesAsync();

            oCuenta = await context.Cuentas.Where(e => e.IdCuenta == cuenta.IdCuenta).FirstOrDefaultAsync();
            return oCuenta;
        }
        public async Task<Cuenta> deleteCuenta(int idCuenta)
        {
            Cuenta oCuenta = new Cuenta();
            oCuenta = await context.Cuentas.Where(e => e.IdCuenta == idCuenta).FirstOrDefaultAsync();

            context.Entry(oCuenta).State = EntityState.Deleted;
            await context.SaveChangesAsync();

            return oCuenta;
        }

    }
}
