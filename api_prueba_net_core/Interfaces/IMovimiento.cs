using api_prueba_net_core.Models.Entidad;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_prueba_net_core.Interfaces
{
    public interface IMovimiento
    {
        Task<IEnumerable<Movimiento>> getMovimiento();
        Task<Movimiento> postMovimiento(Movimiento movimiento);
        Task<Movimiento> putMovimiento(Movimiento movimiento);
        Task<Movimiento> deleteMovimiento(int idMovimiento);
    }
}
