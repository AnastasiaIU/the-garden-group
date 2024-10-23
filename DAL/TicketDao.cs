using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    /// <summary>
    /// Data Access Object (DAO) for managing Ticket-related operations in the MongoDB database.
    /// </summary>
    public class TicketDao : BaseDao
    {
        #region Orest

        /// <summary>
        /// Asynchronously retrieves a list of all tickets from the MongoDB collection.<para />
        /// Used in the API feature.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Ticket"/> objects.</returns>
        public async Task<List<Ticket>> GetAllTicketsAsync()
        {
            var filter = Builders<Ticket>.Filter.Empty;
            return await ticketCollection.Find(filter).ToListAsync();
        }

        #endregion

        #region Naz

        /// <summary>
        /// Asynchronously retrieves all tickets along with the reporting user's first and last name.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Ticket"/> objects.</returns>
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

        /// <summary>
        /// Asynchronously retrieves all tickets for a specific regular employee, along with the employee's first and last name.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Ticket"/> objects.</returns>
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

        /// <summary>
        /// Maps a list of BSON documents to a list of <see cref="Ticket"/> objects.
        /// </summary>
        /// <param name="ticketDocuments">A list of BSON documents representing tickets.</param>
        /// <returns>A list of <see cref="Ticket"/> objects.</returns>
        public List<Ticket> MapToTickets(List<BsonDocument> ticketDocuments)
        {
            // Select and turn each BSON document to a Ticket object
            var ticketList = ticketDocuments.Select(ticketDoc => new Ticket(
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
                ticketDoc["creation_date"].ToUniversalTime(),
                ticketDoc["_id"].AsObjectId.ToString()
            )
            {
                ReportingEmployeeFirstName = ticketDoc["reporting_employee"]["first_name"].AsString,
                ReportingEmployeeLastName = ticketDoc["reporting_employee"]["last_name"].AsString
            }).ToList();

            return ticketList;
        }

        #endregion

        #region Tina

        /// <summary>
        /// Asynchronously sets the <c>isEscalated</c> field of a ticket to true in the MongoDB collection.
        /// </summary>
        /// <param name="ticketId">The unique ID of the ticket to escalate.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task EscalateTicket(string ticketId)
        {
            var filter = Builders<Ticket>.Filter.Eq("_id", new ObjectId(ticketId));
            var update = Builders<Ticket>.Update.Set("is_escalated", true);
            await ticketCollection.UpdateOneAsync(filter, update);
        }

        #endregion

        #region Vladyslav

        /// <summary>
        /// Asynchronously retrieves the total number of tickets reported by a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of tickets.</returns>
        public async Task<int> GetAmountOfAllTicketsForReportingUserAsync(Employee employee)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employee.EmployeeId);

            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of tickets.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of tickets.</returns>
        public async Task<int> GetAmountOfAllTicketsAsync()
        {
            var filter = Builders<Ticket>.Filter.Empty;

            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of resolved tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of resolved tickets.</returns>
        public async Task<int> GetAmountOfAllResolvedTicketsForReportingUserAsync(Employee employee)
        {
            var matchStage = Builders<Ticket>.Filter.And(
            Builders<Ticket>.Filter.Eq("reporting_user", employee.EmployeeId),
            Builders<Ticket>.Filter.Eq("is_resolved", true)
            );

            // Get the count of matching documents
            var count = await ticketCollection.CountDocumentsAsync(matchStage);

            return (int)count;
        }

        /// <summary>
        /// Asynchronously retrieves the total number of resolved tickets.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of resolved tickets.</returns>
        public async Task<int> GetAmountOfAllResolvedTicketsAsync()
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.IsResolved, true);

            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of open tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of open tickets.</returns>
        public async Task<int> GetAmountOfAllOpenTicketsForReportingUserAsync(Employee employee)
        {
            var matchStage = Builders<Ticket>.Filter.And(
            Builders<Ticket>.Filter.Eq("reporting_user", employee.EmployeeId),
            Builders<Ticket>.Filter.Eq("status", "Open")
            );

            // Get the count of matching documents
            var count = await ticketCollection.CountDocumentsAsync(matchStage);

            return (int)count;
        }

        /// <summary>
        /// Asynchronously retrieves the total number of open tickets.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of open tickets.</returns>
        public async Task<int> GetAmountOfAllOpenTicketsAsync()
        {
            var filter = Builders<Ticket>.Filter.Eq("status", Status.Open);

            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of closed tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of closed tickets.</returns>
        public async Task<int> GetAmountOfAllClosedTicketsForReportingUserAsync(Employee employee)
        {
            var matchStage = Builders<Ticket>.Filter.And(
            Builders<Ticket>.Filter.Eq("reporting_user", employee.EmployeeId),
            Builders<Ticket>.Filter.Eq("status", "Closed")
            );

            // Get the count of matching documents
            var count = await ticketCollection.CountDocumentsAsync(matchStage);

            return (int)count;
        }

        /// <summary>
        /// Asynchronously retrieves the total number of closed tickets.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of closed tickets.</returns>
        public async Task<int> GetAmountOfAllClosedTicketsAsync()
        {
            var filter = Builders<Ticket>.Filter.Eq("status", "Closed");

            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        #endregion

        #region Danylo

        /// <summary>
        /// Asynchronously adds a new ticket to the MongoDB collection.
        /// </summary>
        /// <param name="ticket">The new ticket to be added.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task AddTicketAsync(Ticket ticket)
        {
            await ticketCollection.InsertOneAsync(ticket);
        }

        /// <summary>
        /// Asynchronously updates an existing ticket in the MongoDB collection.
        /// </summary>
        /// <param name="updatedTicket">The ticket with updated information.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task UpdateTicketAsync(Ticket updatedTicket)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.TicketId, updatedTicket.TicketId);
            await ticketCollection.ReplaceOneAsync(filter, updatedTicket);
        }

        /// <summary>
        /// Asynchronously closes a ticket in the MongoDB collection by updating its status to "Closed".
        /// </summary>
        /// <param name="ticketId">The unique ID of the ticket to be closed.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation of updating the ticket's status.</returns>
        public async Task CloseTicketAsync(string ticketId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.TicketId, ticketId);
            var update = Builders<Ticket>.Update
                .Set(t => t.Status, Status.Closed);

            await ticketCollection.UpdateOneAsync(filter, update);
        }

        #endregion
    }
}
