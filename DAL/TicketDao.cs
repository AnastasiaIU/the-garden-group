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

        public async Task<List<Ticket>> GetOpenTicketsForEmployeeAsync()
        {
            var filter = Builders<Ticket>.Filter.Ne(t => t.Status, Status.Closed);
            return await ticketCollection.Find(filter).ToListAsync();
        }
    }
}