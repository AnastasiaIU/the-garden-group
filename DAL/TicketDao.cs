using Model;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDao : BaseDao
    {
        public async Task<List<Ticket>> GetAllTicketsAsync()
        {
            var filter = Builders<Ticket>.Filter.Empty;
            return await ticketCollection.Find(filter).ToListAsync();
        }

        public async Task<int> CountTicketsForEmployeeAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }
    }
}