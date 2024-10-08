using DAL;
using Model;

namespace Service
{
    public class TicketService
    {
        private readonly TicketDao ticketDao = new();

        public async Task<int> CountTicketsForEmployeeAsync(string employeeId)
        {
            return await ticketDao.CountTicketsForEmployeeAsync(employeeId);
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