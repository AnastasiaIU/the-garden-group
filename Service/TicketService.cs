using DAL;

namespace Service
{
    public class TicketService
    {
        private readonly TicketDao ticketDao = new();

        public async Task<int> CountTicketsForEmployeeAsync(string employeeId)
        {
            return await ticketDao.CountTicketsForEmployeeAsync(employeeId);
        }
    }
}