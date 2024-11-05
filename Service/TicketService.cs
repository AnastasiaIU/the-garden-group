using DAL;
using Model;

namespace Service
{
    /// <summary>
    /// Service layer for managing ticket-related operations. Provides business logic and interacts with the data access layer (TicketDao).
    /// </summary>

    public class TicketService : BaseService<Ticket, TicketDao>
    {
        #region Orest

        /// <summary>
        /// Asynchronously retrieves all tickets from the database.<para />
        /// Used in the API feature.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of all <see cref="Ticket"/> objects.</returns>
        public async Task<List<Ticket>> GetAllTicketsAPI()
        {
            return await dao.GetAllTicketsAPI();
        }

        /// <summary>
        /// Asynchronously updates a ticket in the MongoDB collection by its unique ID.<para />
        /// Used in the API feature.
        /// </summary>
        public async Task UpdateTicketAPI(string id, Ticket updatedTicket)
        {
            await dao.UpdateTicketAPI(id, updatedTicket);
        }

        /// <summary>
        /// Asyncrhonously deletes a ticket from the MongoDB collection by its unique ID.<para />
        /// Used in the API feature.
        /// </summary>
        public async Task DeleteTicketByIdAPI(string id)
        {
            await dao.DeleteTicketByIdAPI(id);
        }

        #endregion

        #region Naz

        /// <summary>
        /// Asynchronously retrieves all tickets for service desk employees, including the reporting user's details.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Ticket"/> objects.</returns>
        public async Task<List<Ticket>> GetAllTicketsWithReportingUserNameAsync()
        {
            return await dao.GetAllTicketsWithReportingUserNameAsync();
        }

        /// <summary>
        /// Asynchronously retrieves all tickets reported by a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee reporting the tickets.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Ticket"/> objects.</returns>
        public async Task<List<Ticket>> GetTicketsForRegularEmployeeAsync(Employee employee)
        {
            return await dao.GetTicketsForRegularEmployeeAsync(employee);
        }
        public async Task<List<Ticket>> SearchTicketsByKeywordsAsync(Employee employee, string keywordString)
        {
            return await dao.SearchTicketsByKeywordsAsync(employee, keywordString);
        }

        #endregion

        #region Tina

        /// <summary>
        /// Asynchronously escalates a ticket by setting its status to escalated.
        /// </summary>
        /// <param name="ticketId">The unique ID of the ticket to escalate.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task EscalateTicket(Ticket ticket)
        {
            await dao.EscalateTicket(ticket);
        }

        #endregion

        #region Vladyslav

        /// <summary>
        /// Asynchronously retrieves the total number of tickets reported by a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of tickets.</returns>
        public async Task<int> GetAmountOfAllTicketsForReportingUser(Employee employee)
        {
            return await dao.GetAmountOfAllTicketsForReportingUser(employee);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of all tickets in the database.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of tickets.</returns>
        public async Task<int> GetAmountOfAllTickets()
        {
            return await dao.GetAmountOfAllTickets();
        }

        /// <summary>
        /// Asynchronously retrieves the total number of resolved tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of resolved tickets.</returns>
        public async Task<int> GetAmountOfAllResolvedTicketsForReportingUser(Employee employee)
        {
            return await dao.GetAmountOfAllResolvedTicketsForReportingUser(employee);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of all resolved tickets in the database.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of resolved tickets.</returns>
        public async Task<int> GetAmountOfAllResolvedTickets()
        {
            return await dao.GetAmountOfAllResolvedTickets();
        }

        /// <summary>
        /// Asynchronously retrieves the total number of open tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of open tickets.</returns>
        public async Task<int> GetAmountOfAllOpenTicketsForReportingUser(Employee employee)
        {
            return await dao.GetAmountOfAllOpenTicketsForReportingUser(employee);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of all open tickets in the database.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of open tickets.</returns>
        public async Task<int> GetAmountOfAllOpenTickets()
        {
            return await dao.GetAmountOfAllOpenTickets();
        }

        /// <summary>
        /// Asynchronously retrieves the total number of closed tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of closed tickets.</returns>
        public async Task<int> GetAmountOfAllClosedTicketsForReportingUser(Employee employee)
        {
            return await dao.GetAmountOfAllClosedTicketsForReportingUser(employee);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of all closed tickets in the database.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of closed tickets.</returns>
        public async Task<int> GetAmountOfAllClosedTickets()
        {
            return await dao.GetAmountOfAllClosedTickets();
        }

        /// <summary>
        /// Asynchronously returns the list of filtered tickets based on the loaded list and common keywords.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the list of tickets.</returns>
        public async Task<List<Ticket>> GetFilteredTickets(List<Ticket> tickets, string commonKeywordsInput)
        {
            string[] commonKeywords = commonKeywordsInput.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var filteredTickets = tickets.AsQueryable();

            foreach (string keyword in commonKeywords)
            {
                filteredTickets = filteredTickets.Where(ticket =>
                ticket.Title.ToLower().Contains(keyword.ToLower()) ||
                ticket.Description.ToLower().Contains(keyword.ToLower()));
            }

            return filteredTickets.ToList();
        }



        #endregion

        #region Danylo

        /// <summary>
        /// Asynchronously updates a ticket in the database.
        /// </summary>
        /// <param name="updatedTicket">The <see cref="Ticket"/> object containing the updated information.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task UpdateTicketAsync(Ticket updatedTicket)
        {
            await dao.UpdateTicketAsync(updatedTicket);
        }

        /// <summary>
        /// Asynchronously adds a new ticket to the database.
        /// </summary>
        /// <param name="ticket">The <see cref="Ticket"/> object representing the new ticket.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task AddTicketAsync(Ticket ticket)
        {
            await dao.AddTicketAsync(ticket);
        }

        /// <summary>
        /// Asynchronously closes a ticket by updating its status to "Closed".
        /// </summary>
        /// <param name="ticketId">The unique ID of the ticket to close.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task CloseTicketAsync(string ticketId)
        {
            await dao.CloseTicketAsync(ticketId);
        }

        #endregion

        #region Sia

        /// <summary>
        /// Updates the assigned service desk employee for the specified ticket asynchronously.
        /// </summary>
        /// <param name="ticket">The <see cref="Ticket"/> object containing updated information on the assigned service desk employee.</param>
        /// <returns>A task representing the asynchronous update operation.</returns>
        public async Task UpdateServiceDeskEmployee(Ticket ticket)
        {
            await dao.UpdateServiceDeskEmployee(ticket);
        }

        #endregion
    }
}
