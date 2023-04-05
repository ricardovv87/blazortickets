using SistemadeTickets.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SistemadeTickets.Client.Services
{
    public class ServicesTipos : IservicesTipos
    {
        private readonly HttpClient _httpclient;

        public ServicesTipos(HttpClient httpclient) 
        {
        _httpclient = httpclient;
        }

        public async Task<IEnumerable<Tipos>> TiposCat()
        {
            return await _httpclient.GetFromJsonAsync<IEnumerable<Tipos>>($"api/tipos");
        }
    }
}
