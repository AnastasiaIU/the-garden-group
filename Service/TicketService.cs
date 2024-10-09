using DAL;
using Model;

namespace Service
{
    public class TicketService
    {
        private readonly TicketDao ticketDao = new();

        public async Task<List<Ticket>> GetAllTicketsAsync()
        {
            return await ticketDao.GetAllTicketsAsync();
        }
    }
}