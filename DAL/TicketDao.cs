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
        // Sets the isEscalated field in a ticket to true in the database
        public async Task EscalateTicket(string ticketId)
        {
            var filter = Builders<Ticket>.Filter.Eq("_id", new ObjectId(ticketId));
            var update = Builders<Ticket>.Update.Set("is_escalated", true);
            await ticketCollection.UpdateOneAsync(filter, update);
        }

        //Vladyslav
        public async Task<int> GetAmountOfAllTicketsForReportingUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> GetAmountOfAllTicketsForServiceDeskUserAsync()
        {
            var filter = Builders<Ticket>.Filter.Empty;
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> GetAmountOfAllResolvedTicketsForReportingUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId)
                & Builders<Ticket>.Filter.Eq(t => t.IsResolved, true)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Closed);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> GetAmountOfAllResolvedTicketsForServiceDeskUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.IsResolved, true)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Closed);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> GetAmountOfAllOpenTicketsForReportingUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId)
                & Builders<Ticket>.Filter.Eq(t => t.IsResolved, false)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Open);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> GetAmountOfAllOpenTicketsForServiceDeskUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.IsResolved, false)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Open);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> GetAmountOfAllClosedTicketsForReportingUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId)
                & Builders<Ticket>.Filter.Eq(t => t.IsResolved, false)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Closed);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        public async Task<int> GetAmountOfAllClosedTicketsForServiceDeskUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.IsResolved, false)
                & Builders<Ticket>.Filter.Eq(t => t.Status, Status.Closed);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        //Danylo
        public async Task AddTicketAsync(Ticket ticket)
        {
            await ticketCollection.InsertOneAsync(ticket);
        }

        public async Task UpdateTicketAsync(Ticket updatedTicket)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.TicketId, updatedTicket.TicketId);

            var update = Builders<Ticket>.Update
                .Set(t => t.ReportingUser, updatedTicket.ReportingUser)
                .Set(t => t.ServiceDeskUser, updatedTicket.ServiceDeskUser)
                .Set(t => t.Title, updatedTicket.Title)
                .Set(t => t.Description, updatedTicket.Description)
                .Set(t => t.Status, updatedTicket.Status)
                .Set(t => t.Priority, updatedTicket.Priority)
                .Set(t => t.IsResolved, updatedTicket.IsResolved)
                .Set(t => t.IsEscalated, updatedTicket.IsEscalated)
                .Set(t => t.Deadline, updatedTicket.Deadline)
                .Set(t => t.IncidentType, updatedTicket.IncidentType)
                .Set(t => t.CreationDate, updatedTicket.CreationDate);

            await ticketCollection.UpdateOneAsync(filter, update);
        }
    }
}
