using SistemadeTickets.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace SistemadeTickets.Client.Services
{
    public class ServicesTicket : IservicesTicket
    {
        private readonly HttpClient _httpclient;

        public ServicesTicket(HttpClient httpclient) 
        {
            _httpclient = httpclient;
        }

        public async Task DeleteTicket(int Id)
        {
            await _httpclient.DeleteAsync($"api/tickets/{Id}");
        }

        public async Task<Ticket> GetDetails(int Id)
        {
          return await _httpclient.GetFromJsonAsync<Ticket>($"api/tickets/{Id}");
        }

        public async Task<IEnumerable<Ticket>> GetTicket()
        {
         return await _httpclient.GetFromJsonAsync<IEnumerable<Ticket>>($"api/tickets");
        }

        public async Task SaveTicket(Ticket Ticket)
        {
            if (Ticket.Id == 0)
            {
                await _httpclient.PostAsJsonAsync<Ticket>($"api/tickets", Ticket);
            }
            else 
            {
                await _httpclient.PutAsJsonAsync<Ticket>($"api/tickets/{Ticket.Id}", Ticket);
            }
        }

        //public async Task<IEnumerable<Ticket>> SoloAbiertos()
        //{
        //    return await _httpclient.GetFromJsonAsync<IEnumerable<Ticket>>($"api/tickets");
        //}
    }
}
