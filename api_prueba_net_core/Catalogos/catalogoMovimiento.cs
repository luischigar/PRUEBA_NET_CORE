using api_prueba_net_core.DBContext;
using api_prueba_net_core.Interfaces;
using api_prueba_net_core.Models.Entidad;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
    }
}
