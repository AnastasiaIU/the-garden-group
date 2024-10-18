using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace GardenGroupAPI.Controllers
{
    [Controller]
    [Route("api/ticket")]
    public class TicketController : Controller
    {
        private readonly TicketService _ticketService;

        public TicketController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public async Task<List<Ticket>> Get()
        {
            return await _ticketService.GetAllTicketsAPIAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Ticket ticket)
        {
            await _ticketService.AddTicketAsync(ticket);
            return CreatedAtAction(nameof(Get), new { id = ticket.TicketId }, ticket);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Ticket ticket)
        {
            await _ticketService.UpdateTicketAPIAsync(id, ticket);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _ticketService.DeleteTicketByIDAPIAsync(id);
            return NoContent();
        }
    }
}