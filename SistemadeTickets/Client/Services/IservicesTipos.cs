using SistemadeTickets.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemadeTickets.Client.Services
{
    public interface IservicesTipos
    {
        Task<IEnumerable<Tipos>> TiposCat();
    }
}
