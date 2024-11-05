using DAL;
using Model;
using System.Security.Cryptography;
using System.Text;

namespace Service
{
    /// <summary>
    /// Service layer for managing employee-related operations. Provides business logic and interacts with the data access layer (EmployeeDao).
    /// </summary>
    public class EmployeeService : BaseService<Employee, EmployeeDao>
    {
        #region Orest

        /// <summary>
        /// Asynchronously retrieves all employees from the database.<para />
        /// Used in the API feature.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of all <see cref="Employee"/> objects.</returns>
        public async Task<List<Employee>> GetAllEmployeesAPI()
        {
            return await dao.GetAllEmployeesAPI();
        }

        /// <summary>
        /// Asyncronously updates an employee in the MongoDB collection by their unique ID.<para />
        /// Used in the API feature.
        /// </summary>
        public async Task UpdateEmployeeAPI(string id, Employee updatedEmployee)
        {
            await dao.UpdateEmployeeAPI(id, updatedEmployee);
        }

        /// <summary>
        /// Asyncroniously soft deletes an employee from the MongoDB collection by their unique ID by updating employee's status to "is_deleted".<para />
        /// Used in the API feature.
        /// </summary>
        public async Task DeleteEmployeeByIdAPI(string employeeId)
        {
            await dao.DeleteEmployeeByIdAPI(employeeId);
        }

        /// <summary>
        /// Asynchronously retrieves all employees along with the count of their open tickets.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Employee"/> objects with ticket counts.</returns>
        public async Task<List<Employee>> GetAllEmployeesWithCountedTickets()
        {
            return await dao.GetAllEmployeesWithCountedTickets();
        }

        #endregion

        #region Sia

        /// <summary>
        /// Asynchronously retrieves an employee by their username and hashed password.
        /// </summary>
        /// <param name="username">The username of the employee.</param>
        /// <param name="password">The plain text password of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the <see cref="Employee"/> object if found, otherwise null.</returns>
        public async Task<Employee?> GetEmployeeByUsernameAndPassword(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            return await dao.GetEmployeeByUsernameAndPassword(username, hashedPassword);
        }

        /// <summary>
        /// Hashes a password using SHA256.
        /// </summary>
        /// <param name="password">The plain text password to hash.</param>
        /// <returns>A hashed string representation of the password.</returns>
        private string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new();

            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Checks if the database connection has been successfully established in the Data Access Layer (DAL).
        /// </summary>
        /// <returns>
        /// True if the database is initialized and accessible; otherwise, false.
        /// </returns>
        /// <remarks>
        /// This method calls <see cref="employeeDao.IsDatabaseInitiated"/> to verify the database
        /// initialization status, providing a seamless way to check database connectivity from the Service layer.
        /// </remarks>
        public bool IsDatabaseInitiated()
        {
            return dao.IsDatabaseInitiated;
        }

        /// <summary>
        /// Retrieves an employee by their unique identifier asynchronously.
        /// </summary>
        /// <param name="employeeId">The unique identifier of the employee to retrieve.</param>
        /// <returns>A task representing the asynchronous operation, containing the <see cref="Employee"/> with the specified ID.</returns>
        public async Task<Employee> GetEmployeeById(string employeeId)
        {
            return await dao.GetEmployeeById(employeeId);
        }

        /// <summary>
        /// Retrieves a sorted list of all service desk employees asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, containing a list of <see cref="Employee"/> objects
        /// sorted by predefined criteria for service desk employees.</returns>
        public async Task<List<Employee>> GetAllServiceDeskEmployeesSorted()
        {
            return await dao.GetAllServiceDeskEmployeesSorted();
        }

        #endregion

        #region Tina

        /// <summary>
        /// Asynchronously sets the "is_deleted" field to true for an employee from the MongoDB collection by their unique ID.
        /// </summary>
        /// <param name="deletedEmployee">the employee to be deleted.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task DeleteEmployeeByID(Employee deletedEmployee)
        {
            await dao.DeleteEmployeeByID(deletedEmployee);
        }

        /// <summary>
        /// Asynchronously updates an employee's information in the database.
        /// </summary>
        /// <param name="employee">The <see cref="Employee"/> object containing the updated information.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task UpdateEmployeeAsync(Employee employee)
        {
            await dao.UpdateEmployeeAsync(employee);
        }

        /// <summary>
        /// Asynchronously creates a new employee in the database. Generates a username and a hashed password for the new employee.
        /// </summary>
        /// <param name="employee">The <see cref="Employee"/> object representing the new employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task CreateEmployeeAsync(Employee employee)
        {
            string username = $"{employee.FirstName.ToLower()}.{employee.LastName.ToLower()}";
            string password = HashPassword(username);
            await dao.CreateEmployeeAsync(employee, username, password);
        }

        #endregion
    }
}