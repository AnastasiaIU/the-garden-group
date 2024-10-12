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
        // Method to get all tickets along with the reporting user's first and last name
        public async Task<List<Ticket>> GetAllTicketsForServiceDeskEmployeeAsync()
        {
            var tickets = await ticketCollection
                .Aggregate()
                .Lookup<Employee, Ticket>(  // Join Ticket with Employee collection
                    "Employee",
                    "reporting_user",
                    "_id",
                    "reporting_employee"  // Field name for the joined data
                )
                .Unwind("reporting_employee")
                .Sort(Builders<BsonDocument>.Sort.Descending("deadline")) // Sort tickets by deadline to see most urgent tickets first
                .ToListAsync();

            // Map the BSON documents to Ticket objects
            return MapToTickets(tickets);
        }

        // Naz
        // Method to get tickets that belong to a specific regular employee along with their first and last name
        public async Task<List<Ticket>> GetTicketsForRegularEmployeeAsync(string employeeId)
        {
            // Create a filter to match tickets reported by the specific employee by id
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
        // Method to map a list of BSON documents to a list of Ticket objects
        public List<Ticket> MapToTickets(List<BsonDocument> ticketDocuments)
        {
            // Select and turn each BSON document to a Ticket object
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

        // Tina
        // Escalate a ticket
        public async Task EscalateTicket(string ticketId)
        {
            // create the filter to find the ticket by the Id
            var updateFilter = Builders<Ticket>.Filter.Eq("_id", new ObjectId(ticketId));

            // defining what needs to be updated
            var update = Builders<Ticket>.Update.Set("is_escalated", true);

            // the actual update
            await ticketCollection.UpdateOneAsync(updateFilter, update);
        }
        
    }
}