using DAL;
using Model;
using System.Security.Cryptography;
using System.Text;

namespace Service
{
    public class EmployeeService
    {
        private readonly EmployeeDao employeeDao = new();

        public async Task<List<Employee>> GetAllEmployeesWithCountedTicketsAsync()
        {
            return await employeeDao.GetAllEmployeesWithCountedTicketsAsync();
        }

        public async Task<Employee?> GetEmployeeByUsernameAndPasswordAsync(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            return await employeeDao.GetEmployeeByUsernameAndPasswordAsync(username, hashedPassword);
        }

        //Tina
        public async Task DeleteEmployeeByID(string employeeId)
        {
            await employeeDao.DeleteEmployeeByID(employeeId);
        }
        //Tina
        public async Task UpdateEmployeeAsync(string employeeId, Employee employee)
        {
            await employeeDao.UpdateEmployeeAsync(employeeId, employee);
        }
        //Tina
        public async Task CreateEmployeeAsync(Employee employee)
        {
            await employeeDao.CreateEmployeeAsync(employee);
        } 

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
    }
}