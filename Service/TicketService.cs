using DAL;
using Model;

namespace Service
{
    /// <summary>
    /// Service layer for managing ticket-related operations. Provides business logic and interacts with the data access layer (TicketDao).
    /// </summary>

    public class TicketService
    {
        private readonly TicketDao ticketDao = new();

        #region Orest

        /// <summary>
        /// Asynchronously retrieves all tickets from the database.<para />
        /// Used in the API feature.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of all <see cref="Ticket"/> objects.</returns>
        public async Task<List<Ticket>> GetAllTicketsAsync()
        {
            return await ticketDao.GetAllTicketsAsync();
        }

        #endregion

        #region Naz

        /// <summary>
        /// Asynchronously retrieves all tickets for service desk employees, including the reporting user's details.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Ticket"/> objects.</returns>
        public async Task<List<Ticket>> GetAllTicketsForServiceDeskEmployeeAsync()
        {
            return await ticketDao.GetAllTicketsForServiceDeskEmployeeAsync();
        }

        /// <summary>
        /// Asynchronously retrieves all tickets reported by a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee reporting the tickets.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Ticket"/> objects.</returns>
        public async Task<List<Ticket>> GetTicketsForRegularEmployeeAsync(string employeeId)
        {
            return await ticketDao.GetTicketsForRegularEmployeeAsync(employeeId);
        }

        #endregion

        #region Tina

        /// <summary>
        /// Asynchronously escalates a ticket by setting its status to escalated.
        /// </summary>
        /// <param name="ticketId">The unique ID of the ticket to escalate.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task EscalateTicket(string ticketId)
        {
            await ticketDao.EscalateTicket(ticketId);
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
            return await ticketDao.GetAmountOfAllTicketsForReportingUserAsync(employee);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of all tickets in the database.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of tickets.</returns>
        public async Task<int> GetAmountOfAllTicketsAsync()
        {
            return await ticketDao.GetAmountOfAllTicketsAsync();
        }

        /// <summary>
        /// Asynchronously retrieves the total number of resolved tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of resolved tickets.</returns>
        public async Task<int> GetAmountOfAllResolvedTicketsForReportingUserAsync(Employee employee)
        {
            return await ticketDao.GetAmountOfAllResolvedTicketsForReportingUserAsync(employee);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of all resolved tickets in the database.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of resolved tickets.</returns>
        public async Task<int> GetAmountOfAllResolvedTicketsAsync()
        {
            return await ticketDao.GetAmountOfAllResolvedTicketsAsync();
        }

        /// <summary>
        /// Asynchronously retrieves the total number of open tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of open tickets.</returns>
        public async Task<int> GetAmountOfAllOpenTicketsForReportingUserAsync(Employee employee)
        {
            return await ticketDao.GetAmountOfAllOpenTicketsForReportingUserAsync(employee);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of all open tickets in the database.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of open tickets.</returns>
        public async Task<int> GetAmountOfAllOpenTicketsAsync()
        {
            return await ticketDao.GetAmountOfAllOpenTicketsAsync();
        }

        /// <summary>
        /// Asynchronously retrieves the total number of closed tickets for a specific regular employee.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of closed tickets.</returns>
        public async Task<int> GetAmountOfAllClosedTicketsForReportingUserAsync(Employee employee)
        {
            return await ticketDao.GetAmountOfAllClosedTicketsForReportingUserAsync(employee);
        }

        /// <summary>
        /// Asynchronously retrieves the total number of all closed tickets in the database.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the total number of closed tickets.</returns>
        public async Task<int> GetAmountOfAllClosedTicketsAsync()
        {
            return await ticketDao.GetAmountOfAllClosedTicketsAsync();
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
            await ticketDao.UpdateTicketAsync(updatedTicket);
        }

        /// <summary>
        /// Asynchronously adds a new ticket to the database.
        /// </summary>
        /// <param name="ticket">The <see cref="Ticket"/> object representing the new ticket.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task AddTicketAsync(Ticket ticket)
        {
            await ticketDao.AddTicketAsync(ticket);
        }

        /// <summary>
        /// Asynchronously closes a ticket by updating its status to "Closed".
        /// </summary>
        /// <param name="ticketId">The unique ID of the ticket to close.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task CloseTicketAsync(string ticketId)
        {
            await ticketDao.CloseTicketAsync(ticketId);
        }

        #endregion
    }
}
