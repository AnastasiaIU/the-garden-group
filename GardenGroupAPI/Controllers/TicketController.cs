using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace GardenGroupAPI.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class TicketController : Controller
    {
        private readonly TicketDao _ticketDao;

        public TicketController(TicketDao ticketDao)
        {
            _ticketDao = ticketDao;
        }

        [HttpGet]
        public async Task<List<Ticket>> Get()
        {
            return await _ticketDao.GetAllTicketsAsync();
        }
    }
}