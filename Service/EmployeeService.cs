using DAL;
using Model;
using System.Security.Cryptography;
using System.Text;

namespace Service
{
    /// <summary>
    /// Service layer for managing employee-related operations. Provides business logic and interacts with the data access layer (EmployeeDao).
    /// </summary>
    public class EmployeeService
    {
        private readonly EmployeeDao employeeDao = new();

        #region Orest

        /// <summary>
        /// Asynchronously retrieves all employees from the database.<para />
        /// Used in the API feature.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of all <see cref="Employee"/> objects.</returns>
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await employeeDao.GetAllEmployeesAsync();
        }

        /// <summary>
        /// Asynchronously retrieves all employees along with the count of their open tickets.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Employee"/> objects with ticket counts.</returns>
        public async Task<List<Employee>> GetAllEmployeesWithCountedTicketsAsync()
        {
            return await employeeDao.GetAllEmployeesWithCountedTicketsAsync();
        }

        #endregion

        #region Sia

        /// <summary>
        /// Asynchronously retrieves an employee by their username and hashed password.
        /// </summary>
        /// <param name="username">The username of the employee.</param>
        /// <param name="password">The plain text password of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the <see cref="Employee"/> object if found, otherwise null.</returns>
        public async Task<Employee?> GetEmployeeByUsernameAndPasswordAsync(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            return await employeeDao.GetEmployeeByUsernameAndPasswordAsync(username, hashedPassword);
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

        #endregion

        #region Tina

        /// <summary>
        /// Asynchronously deletes an employee from the database by their unique ID.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee to delete.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task DeleteEmployeeByID(string employeeId)
        {
            await employeeDao.DeleteEmployeeByID(employeeId);
        }

        /// <summary>
        /// Asynchronously updates an employee's information in the database.
        /// </summary>
        /// <param name="employee">The <see cref="Employee"/> object containing the updated information.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task UpdateEmployeeAsync(Employee employee)
        {
            await employeeDao.UpdateEmployeeAsync(employee);
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
            await employeeDao.CreateEmployeeAsync(employee, username, password);
        }

        #endregion
    }
}