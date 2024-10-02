using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDao : BaseDao
    {
        public async Task<List<Ticket>> GetAllTicketsAsync()
        {
            var filter = Builders<Ticket>.Filter.Empty;
            return await _ticketCollection.Find(filter).ToListAsync();
        }

        public async Task<int> CountTicketsForEmployeeAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId);
            return (int)await _ticketCollection.CountDocumentsAsync(filter);
        }
    }
}