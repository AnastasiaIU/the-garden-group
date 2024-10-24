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
        public async Task<List<Ticket>> GetAllTicketsAPIAsync()
        {
            var filter = Builders<Ticket>.Filter.Empty;
            return await ticketCollection.Find(filter).ToListAsync();
        }

        /// <summary>
        /// Asynchronously updates a ticket in the MongoDB collection by its unique ID.<para />
        /// Used in the API feature.
        /// </summary>
        public async Task UpdateTicketAPIAsync(string id, Ticket updatedTicket)
        {
            updatedTicket.TicketId = id;
            var filter = Builders<Ticket>.Filter.Eq("_id", new ObjectId(id));
            await ticketCollection.ReplaceOneAsync(filter, updatedTicket);
        }

        /// <summary>
        /// Asyncrhonously deletes a ticket from the MongoDB collection by its unique ID.<para />
        /// Used in the API feature.
        /// </summary>
        public async Task DeleteTicketByIDAPIAsync(string ticketId)
        {
            await ticketCollection.DeleteOneAsync(t => t.TicketId == ticketId);
        }

        #endregion

        #region Naz

        /// <summary>
        /// Asynchronously retrieves all tickets along with the reporting user's first and last name.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Ticket"/> objects.</returns>
        public async Task<List<Ticket>> GetAllTicketsWithReportingUserNameAsync()
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
        public async Task<List<Ticket>> GetTicketsForRegularEmployeeAsync(Employee employee)
        {
            string employeeId = employee.EmployeeId;

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
        // method searches for tickets based on keywords and employee role
        public async Task<List<Ticket>> SearchTicketsByKeywordsAsync(Employee employee, string keywordString)
        {
            // make a filter based on the keywords in the keyword string
            var keywordFilter = GetKeywordFilter(keywordString);

            var combinedFilter = keywordFilter;

            // If the employee is a regular employee, only allow them to see their own tickets
            if (employee.Role == EmployeeRole.RegularEmployee)
            {
                var employeeFilter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employee.EmployeeId);
                combinedFilter = Builders<Ticket>.Filter.And(keywordFilter, employeeFilter); // Combine the keyword filter with the employee filter
            }

            return await GetTicketsWithFilter(combinedFilter);
        }

        // Naz
        // Creates a filter based on the keywords provided
        private FilterDefinition<Ticket> GetKeywordFilter(string keywordString)
        {
            // Split the keyword string into individual keywords
            var keywords = keywordString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var filters = keywords.Select(keyword =>
                Builders<Ticket>.Filter.Or(
                    Builders<Ticket>.Filter.Regex(t => t.Title, new BsonRegularExpression(keyword, "i")), // for case insensitive
                    Builders<Ticket>.Filter.Regex(t => t.Description, new BsonRegularExpression(keyword, "i"))
                )
            );

            // Combine all the keyword filters into one filter
            return Builders<Ticket>.Filter.And(filters);
        }

        // Naz
        // method gets tickets based on the provided filter
        private async Task<List<Ticket>> GetTicketsWithFilter(FilterDefinition<Ticket> filter)
        {
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
                .Sort(Builders<BsonDocument>.Sort.Descending("creation_date")) // see most recent at the top
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
        public async Task<int> GetAmountOfAllTicketsForReportingUserAsync(string employeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ReportingUser, employeeId);
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
        public async Task<int> GetAmountOfAllResolvedTicketsForReportingUserAsync(string employeeId)
        {
            var matchStage = Builders<Ticket>.Filter.Where(t => t.ReportingUser == employeeId && t.IsResolved);

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
        public async Task<int> GetAmountOfAllOpenTicketsForReportingUserAsync(string employeeId)
        {
            var matchStage = Builders<Ticket>.Filter.Where(t => t.ReportingUser == employeeId && t.Status == Status.Open);

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
            var filter = Builders<Ticket>.Filter.Eq(t => t.Status, Status.Open);
            return (int)await ticketCollection.CountDocumentsAsync(filter);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of closed tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of closed tickets.</returns>
        public async Task<int> GetAmountOfAllClosedTicketsForReportingUserAsync(string employeeId)
        {
            var matchStage = Builders<Ticket>.Filter.Where(t => t.ReportingUser == employeeId && t.Status == Status.Closed);

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
            var filter = Builders<Ticket>.Filter.Eq(t => t.Status, Status.Closed);
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
