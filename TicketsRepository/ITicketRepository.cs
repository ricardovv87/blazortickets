using SistemadeTickets.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsRepository
{
    public interface ITicketRepository
    {
        Task<bool> InsertTicket(Ticket ticket);

        Task<bool> UpdateTicket(Ticket ticket);

        Task DeleteTicket(int Id);

        Task<IEnumerable<Ticket>> GetTickets();

        Task<Ticket> GetDetails(int Id);

        Task<IEnumerable<Ticket>> SoloAbiertos();

        

    }
}
