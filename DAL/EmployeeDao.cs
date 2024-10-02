using Model;
using MongoDB.Driver;

namespace DAL
{
    public class EmployeeDao : BaseDao
    {
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            var filter = Builders<Employee>.Filter.Empty;
            return await employeeCollection.Find(filter).ToListAsync();
        }

        public async Task<Employee?> GetEmployeeByUsernameAndPasswordAsync(string username, string password)
        {
            try
            {
                var filter = Builders<Employee>.Filter.And(
                Builders<Employee>.Filter.Eq("username", username),
                Builders<Employee>.Filter.Eq("password", password)
                );
                return await employeeCollection.Find(filter).SingleAsync();
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }
    }
}