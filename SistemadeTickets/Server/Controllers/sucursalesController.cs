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
    public class sucursalesController : ControllerBase
    {
        private readonly ISucursalesRepository _sucursalesrepository;

        public sucursalesController(ISucursalesRepository sucursalesRepository)
        {
            _sucursalesrepository = sucursalesRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Sucursales>> getSucursales()
        {
            return await _sucursalesrepository.GetSucursales();
        }


    }
}
