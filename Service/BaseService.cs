using DAL;

namespace Service
{
    #region Orest

    /// <summary>
    /// Base service class is used to provide the basic functionality to the service classes.
    /// It accepts the generic type of the model and the dao class.
    /// </summary>
    /// <typeparam name="T">One of the model classes, Employee or Ticket</typeparam>
    /// <typeparam name="TDao">One of the dao classes, EmployeeDao or TicketDao</typeparam>
    public abstract class BaseService<T, TDao> where TDao : BaseDao<T>, new()
    {
        protected readonly TDao dao = new();

        /// <summary>
        /// This method is used to check if the internet connection is available. It tries to list database names to validate the connection.
        /// </summary>
        /// <returns>True if connection with database exist, otherwise false</returns>
        public async Task<bool> IsDatabaseConnctionAvailable()
        {
            return await dao.IsDatabaseConnctionAvailable();
        }
    }

    #endregion
}