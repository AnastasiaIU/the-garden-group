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

    }
}