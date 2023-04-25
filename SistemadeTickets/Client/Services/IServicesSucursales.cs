using SistemadeTickets.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemadeTickets.Client.Services
{
    public interface IServicesSucursales
    {
        Task<IEnumerable<Sucursales>>getsucursales();
    }
}
