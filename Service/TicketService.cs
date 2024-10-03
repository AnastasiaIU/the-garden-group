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

        public async Task<List<Ticket>> GetOpenTicketsForEmployeeAsync()
        {
            return await ticketDao.GetOpenTicketsForEmployeeAsync();
        }

        public Dictionary<string, int> CountTickets(List<Ticket> tickets)
        {
            return tickets
                .GroupBy(ticket => ticket.ReportingUser)
                .ToDictionary(group => group.Key, group => group.Count());
        }
    }
}