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
        public async Task<int> GetAmountOfAllTicketsForReportingUserAsync(string employeeId)
        {
            return await ticketDao.GetAmountOfAllTicketsForReportingUserAsync(employeeId);
        }

        public async Task<int> GetAmountOfAllTicketsForServiceDeskUserAsync()
        {
            return await ticketDao.GetAmountOfAllTicketsForServiceDeskUserAsync();
        }
        public async Task<int> GetAmountOfAllResolvedTicketsForReportingUserAsync(string employeeId)
        {
            return await ticketDao.GetAmountOfAllResolvedTicketsForReportingUserAsync(employeeId);
        }

        public async Task<int> GetAmountOfAllResolvedTicketsForServiceDeskUserAsync(string employeeId)
        {
            return await ticketDao.GetAmountOfAllResolvedTicketsForServiceDeskUserAsync(employeeId);
        }

        public async Task<int> GetAmountOfAllOpenTicketsForReportingUserAsync(string employeeId)
        {
            return await ticketDao.GetAmountOfAllOpenTicketsForReportingUserAsync(employeeId);
        }

        public async Task<int> GetAmountOfAllOpenTicketsForServiceDeskUserAsync(string employeeId)
        {
            return await ticketDao.GetAmountOfAllOpenTicketsForServiceDeskUserAsync(employeeId);
        }

        public async Task<int> GetAmountOfAllClosedTicketsForReportingUserAsync(string employeeId)
        {
            return await ticketDao.GetAmountOfAllClosedTicketsForReportingUserAsync(employeeId);
        }

        public async Task<int> GetAmountOfAllClosedTicketsForServiceDeskUserAsync(string employeeId)
        {
            return await ticketDao.GetAmountOfAllClosedTicketsForServiceDeskUserAsync(employeeId);
        }

        //Danylo
        public async Task UpdateTicketAsync(Ticket updatedTicket)
        { 
            ticketDao.UpdateTicketAsync(updatedTicket);
        }

        public async Task AddTicketAsync(Ticket ticket)
        { 
            ticketDao.AddTicketAsync(ticket);
        }
    }
}
