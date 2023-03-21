using SistemadeTickets.Shared;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SistemadeTickets.Client.Services
{
    public interface IservicesTicket
    {
        Task SaveTicket(Ticket Ticket);

        Task DeleteTicket(int Id);

        Task<IEnumerable<Ticket>> GetTicket();

        Task<Ticket> GetDetails(int Id);




    }
}
