using SistemadeTickets.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SistemadeTickets.Client.Services
{
    public class ServicesIngeniero:IservicesIngeniero
    {
        private readonly HttpClient _httpclient;

         public ServicesIngeniero(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task DeleteIng(int Id)
        {
            await _httpclient.DeleteAsync($"api/ingeniero/{Id}");
        }

        public async Task<IEnumerable<Ingeniero>> GetIngenieros()
        {
           return await _httpclient.GetFromJsonAsync<IEnumerable<Ingeniero>>($"api/ingeniero");
        }

        public async Task SaveIng(Ingeniero ingeniero)
        {
            await _httpclient.PostAsJsonAsync<Ingeniero>($"api/ingeniero", ingeniero);
        }
    }
}
