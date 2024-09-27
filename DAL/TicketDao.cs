using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDao : BaseDao
    {
        public async Task<int> CountTicketsForEmployeeAsync(ObjectId employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId);
            return (int)await _ticketCollection.CountDocumentsAsync(filter);
        }
    }
}