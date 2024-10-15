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

        //Vladyslav
        //Count tickets
        public async Task<int> CountResolvedTicketsForReportingUserAsync(string employeeId)
        {
            return await ticketDao.CountResolvedTicketsForReportingUserAsync(employeeId);
        }

        public async Task<int> CountResolvedTicketsForServiceDeskUserAsync(string employeeId)
        {
            return await ticketDao.CountResolvedTicketsForServiceDeskUserAsync(employeeId);
        }

        public async Task<int> CountOpenTicketsForReportingUserAsync(string employeeId)
        {
            return await ticketDao.CountOpenTicketsForReportingUserAsync(employeeId);
        }

        public async Task<int> CountOpenTicketsForServiceDeskUserAsync(string employeeId)
        {
            return await ticketDao.CountOpenTicketsForServiceDeskUserAsync(employeeId);
        }

        public async Task<int> CountClosedTicketsForReportingUserAsync(string employeeId)
        {
            return await ticketDao.CountClosedTicketsForReportingUserAsync(employeeId);
        }

        public async Task<int> CountClosedTicketsForServiceDeskUserAsync(string employeeId)
        {
            return await ticketDao.CountClosedTicketsForServiceDeskUserAsync(employeeId);
        }
    }
}
