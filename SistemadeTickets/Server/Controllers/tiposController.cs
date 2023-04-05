using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemadeTickets.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketsRepository;

namespace SistemadeTickets.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tiposController : ControllerBase
    {
        private readonly ITiposRepository _Itipos;

        public tiposController(ITiposRepository tiposRepository) 
        {
            _Itipos = tiposRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Tipos>> GetTipos() 
        {
         return await _Itipos.GetTipos();
        }

    }
}
