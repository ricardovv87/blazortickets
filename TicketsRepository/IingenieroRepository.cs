using SistemadeTickets.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsRepository
{
    public interface IingenieroRepository
    {
         Task<bool> InsertIng(Ingeniero ingeniero);

        public Task DeleteIng(int Id);

        Task<IEnumerable<Ingeniero>> GetIngenieros();

    }
}
