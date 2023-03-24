using SistemadeTickets.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SistemadeTickets.Client.Services
{
    public interface IservicesIngeniero
    {
        Task SaveIng(Ingeniero ingeniero);

        Task DeleteIng(int Id);

        Task<IEnumerable<Ingeniero>> GetIngenieros();
    }
}
