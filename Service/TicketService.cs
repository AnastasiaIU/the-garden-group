using DAL;
using MongoDB.Bson;

namespace Service
{
    public class TicketService
    {
        private readonly TicketDao _ticketDao = new();

        public async Task<int> CountTicketsForEmployeeAsync(string employeeId)
        {
            return await _ticketDao.CountTicketsForEmployeeAsync(employeeId);
        }
    }
}