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
    public class ingenieroController : ControllerBase
    {
        private readonly IingenieroRepository _iingeniero;

        public ingenieroController(IingenieroRepository iingeniero)
        {
            _iingeniero = iingeniero;
        }

        [HttpPost]
        public async Task<IActionResult> post([FromBody] Ingeniero ingeniero) 
        {
            if (ingeniero.Nombre == string.Empty)
            {
                return BadRequest();
            }

            await _iingeniero.InsertIng(ingeniero);
             return NoContent();
        }

        [HttpDelete("{Id}")]
        public async Task Delete(int Id)
        {
            await _iingeniero.DeleteIng(Id);
        }

        [HttpGet]
        public async Task<IEnumerable<Ingeniero>> Get() 
        {
            return await _iingeniero.GetIngenieros();
        }


    }
}
