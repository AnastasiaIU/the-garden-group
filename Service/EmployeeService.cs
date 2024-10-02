using DAL;
using Model;
using System.Security.Cryptography;
using System.Text;

namespace Service
{
    public class EmployeeService
    {
        private readonly EmployeeDao employeeDao = new();

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await employeeDao.GetAllEmployeesAsync();
        }

        public async Task<Employee?> GetEmployeeByUsernameAndPasswordAsync(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            return await employeeDao.GetEmployeeByUsernameAndPasswordAsync(username, hashedPassword);
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