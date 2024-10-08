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
            return await ticketCollection.Find(filter).ToListAsync();
        }

        public async Task<int> CountTicketsForEmployeeAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        // Naz
        public async Task<List<Ticket>> GetAllTicketsForServiceDeskEmployeeAsync()
        {
            var tickets = await ticketCollection
                .Aggregate()
                .Lookup<Employee, Ticket>(
                    "Employee",
                    "reporting_user",
                    "_id",
                    "reporting_employee"
                )
                .Unwind("reporting_employee")
                .Sort(Builders<BsonDocument>.Sort.Descending("deadline"))
                .ToListAsync();

            return MapToTickets(tickets);
        }

        // Naz
        public async Task<List<Ticket>> GetTicketsForRegularEmployeeAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId);

            var tickets = await ticketCollection
                .Aggregate()
                .Match(filter)
                .Lookup<Employee, Ticket>(
                    "Employee",
                    "reporting_user",
                    "_id",
                    "reporting_employee"
                )
                .Unwind("reporting_employee")
                .Sort(Builders<BsonDocument>.Sort.Descending("deadline"))
                .ToListAsync();

            return MapToTickets(tickets);
        }

        // Naz
        public List<Ticket> MapToTickets(List<BsonDocument> ticketDocuments)
        {
            var ticketList = ticketDocuments.Select(ticketDoc => new Ticket(
                ticketDoc["_id"].AsObjectId.ToString(),
                ticketDoc["reporting_user"].AsObjectId.ToString(),
                ticketDoc["service_desk_user"].AsObjectId.ToString(),
                ticketDoc["title"].AsString,
                ticketDoc["description"].AsString,
                Enum.Parse<Status>(ticketDoc["status"].AsString),
                Enum.Parse<Priority>(ticketDoc["priority"].AsString),
                ticketDoc["is_resolved"].AsBoolean,
                ticketDoc["is_escalated"].AsBoolean,
                ticketDoc["deadline"].ToUniversalTime(),
                Enum.Parse<IncidentType>(ticketDoc["type_of_incident"].AsString),
                ticketDoc["creation_date"].ToUniversalTime()
            )
            {
                ReportingEmployeeFirstName = ticketDoc["reporting_employee"]["first_name"].AsString,
                ReportingEmployeeLastName = ticketDoc["reporting_employee"]["last_name"].AsString
            }).ToList();

            return ticketList;
        }
    }
}