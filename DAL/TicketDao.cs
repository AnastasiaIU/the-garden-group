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

        public async Task<int> CountResolvedTicketsForReportingUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId)
                & Builders<Ticket>.Filter.Eq(t => t.IsResolved, true)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Closed);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> CountResolvedTicketsForServiceDeskUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ServiceDeskUser, employeeId)
                & Builders<Ticket>.Filter.Eq(t => t.IsResolved, true)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Closed);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> CountOpenTicketsForReportingUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId)
                & Builders<Ticket>.Filter.Eq(t => t.IsResolved, false)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Open);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> CountOpenTicketsForServiceDeskUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ServiceDeskUser, employeeId)
                & Builders<Ticket>.Filter.Eq(t => t.IsResolved, false)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Open);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> CountClosedTicketsForReportingUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId)
                & Builders<Ticket>.Filter.Eq(t => t.IsResolved, false)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Closed);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> CountClosedTicketsForServiceDeskUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ServiceDeskUser, employeeId)
                & Builders<Ticket>.Filter.Eq(t => t.IsResolved, false)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Closed);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }
    }
}