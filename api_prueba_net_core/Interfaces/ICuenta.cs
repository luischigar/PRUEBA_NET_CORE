using api_prueba_net_core.Models.Entidad;
using api_prueba_net_core.Models.EntidadDto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_prueba_net_core.Interfaces
{
    public interface ICuenta
    {
        Task<IEnumerable<CuentaDTO>> getCuentas();
        Task<Cuenta> postCuentas(Cuenta cuenta);
        Task<Cuenta> putCuenta(Cuenta cuenta);
        Task<Cuenta> deleteCuenta(int idCuenta);
    }
}
