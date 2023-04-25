using SistemadeTickets.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SistemadeTickets.Client.Services
{
    public class ServicesSucursales : IServicesSucursales
    {
        private readonly HttpClient _httpclient;

        public ServicesSucursales(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task<IEnumerable<Sucursales>> getsucursales()
        {
            return await _httpclient.GetFromJsonAsync<IEnumerable<Sucursales>>($"api/sucursales");
        }
           



    
    }
}

