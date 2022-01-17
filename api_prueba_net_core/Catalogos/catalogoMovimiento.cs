using api_prueba_net_core.DBContext;
using api_prueba_net_core.Interfaces;
using api_prueba_net_core.Models.Entidad;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba_net_core.Catalogos
{
    public class catalogoMovimiento : IMovimiento
    {
        private readonly prueba_net_coreContext context;
        private readonly IMapper autoMapper;
        public catalogoMovimiento(prueba_net_coreContext _context, IMapper _autoMapper)
        {
            context = _context;
            autoMapper = _autoMapper;
        }
        public async Task<IEnumerable<Movimiento>> getMovimiento()
        {
            return await context.Movimientos.ToListAsync();
        }

        public async Task<Movimiento> postMovimiento(Movimiento movimiento)
        {
            Movimiento oMovimiento = new Movimiento();
            await context.Movimientos.AddAsync(movimiento);
            await context.SaveChangesAsync();
            return oMovimiento;
        }

        public async Task<Movimiento> putMovimiento(Movimiento movimiento)
        {
            Movimiento oMovimiento = new Movimiento();

            context.Entry(movimiento).State = EntityState.Modified;
            await context.SaveChangesAsync();

            oMovimiento = await context.Movimientos.Where(e => e.IdMovimiento == movimiento.IdMovimiento).FirstOrDefaultAsync();
            return oMovimiento;
        }
        public async Task<Movimiento> deleteMovimiento(int idMovimiento)
        {
            Movimiento oMovimiento = new Movimiento();
            oMovimiento = await context.Movimientos.Where(e => e.IdMovimiento == idMovimiento).FirstOrDefaultAsync();

            context.Entry(oMovimiento).State = EntityState.Deleted;
            await context.SaveChangesAsync();

            return oMovimiento;
        }
    }
}
