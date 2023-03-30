using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemadeTickets.Shared;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketsRepository;

namespace SistemadeTickets.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ticketsController : ControllerBase
    {

        private readonly ITicketRepository _ticketRepository;

        public ticketsController(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        [HttpPost]
        public async Task<IActionResult> post([FromBody] Ticket ticket)
        {
            if (ticket == null)
            {
                return BadRequest();
            }
            if (string.IsNullOrEmpty(ticket.Usuario))
            {
                ModelState.AddModelError("Usuario", "Usuario no puede estar Vacio");
            }
            await _ticketRepository.InsertTicket(ticket);

            return NoContent();

        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> put(int id, [FromBody] Ticket ticket)
        {
            if (ticket == null)
            {
                return BadRequest();
            }
            if (string.IsNullOrEmpty(ticket.Usuario))
            {
                ModelState.AddModelError("Usuario", "Usuario no puede estar Vacio");
            }
            await _ticketRepository.UpdateTicket(ticket);

            return NoContent();

        }

        [HttpGet]
        public async Task<IEnumerable<Ticket>> Get()
        {
            return await _ticketRepository.GetTickets();
        }

        //[HttpGet]
        //public async Task<IEnumerable<Ticket>> Abiertos() 
        //{
        //    return await _ticketRepository.SoloAbiertos();
        //}

        [HttpGet("{Id}")]
        public async Task<Ticket> get(int Id) 
        {
            return await _ticketRepository.GetDetails(Id);
        }

        [HttpDelete("{Id}")]
        public async Task Delete(int Id) 
        {
         await _ticketRepository.DeleteTicket(Id);
        }

    }
}
