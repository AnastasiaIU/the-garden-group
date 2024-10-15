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
        public async Task<List<Ticket>> GetAllTicketsForServiceDeskEmployeeAsync()
        {
            return await ticketDao.GetAllTicketsForServiceDeskEmployeeAsync();
        }

        public async Task<List<Ticket>> GetTicketsForRegularEmployeeAsync(String employeeId)
        {
            return await ticketDao.GetTicketsForRegularEmployeeAsync(employeeId);
        }

        // Tina
        // Escalate a ticket
        public async Task EscalateTicket(string ticketId)
        {
            await ticketDao.EscalateTicket(ticketId);
        }
    }
}