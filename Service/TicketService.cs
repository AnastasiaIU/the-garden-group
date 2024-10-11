using DAL;
using Model;
using MongoDB.Driver;

namespace Service
{
    public class TicketService
    {
        private readonly TicketDao ticketDao = new();

        public async Task<int> CountTicketsForEmployeeAsync(string employeeId)
        {
            return await ticketDao.CountTicketsForEmployeeAsync(employeeId);
        }

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