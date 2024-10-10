using Model;
using MongoDB.Bson;
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
            var filter = Builders<Employee>.Filter.And(
            Builders<Employee>.Filter.Eq("username", username),
            Builders<Employee>.Filter.Eq("password", password)
            );
            return await employeeCollection.Find(filter).FirstOrDefaultAsync();
        }

        //Tina 
        public async Task DeleteEmployeeByID(string employeeId)
        {
            // create the filter to find the employee by thier Id
            var deleteFilter = Builders<Employee>.Filter.Eq("_id", new ObjectId(employeeId));
            await employeeCollection.DeleteOneAsync(deleteFilter);
        }

        //Tina
        public async Task UpdateEmployeeAsync(string employeeId, Employee updatedEmployee)
        {
            // create the filter to find the employee by thier Id
            var updateFilter = Builders<Employee>.Filter.Eq("_id", new ObjectId(employeeId));
            // defining everything that needs to be updated
            var update = Builders<Employee>.Update
                .Set("first_name", updatedEmployee.FirstName)
                .Set("last_name", updatedEmployee.LastName)
                .Set("email", updatedEmployee.Email)
                .Set("phone_number", updatedEmployee.PhoneNumber)
                .Set("role", updatedEmployee.Role.ToString())
                .Set("branch", updatedEmployee.Branch);
            // the actual update
            await employeeCollection.UpdateOneAsync(updateFilter, update);
        }

        //Tina
        public async Task CreateEmployeeAsync(Employee newEmployee)
        {
            await employeeCollection.InsertOneAsync(newEmployee);
        }
    }
}