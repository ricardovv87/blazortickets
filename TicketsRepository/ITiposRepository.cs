using SistemadeTickets.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsRepository
{
    public interface ITiposRepository
    {
        Task<IEnumerable<Tipos>> GetTipos();

    }
}
