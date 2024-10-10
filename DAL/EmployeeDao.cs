using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text;
using System.Security.Cryptography;

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

            // add the username and password to the employee
            // the filters to find the student 
            var filter = Builders<Employee>.Filter.And(
            Builders<Employee>.Filter.Eq("first_name", newEmployee.FirstName),
            Builders<Employee>.Filter.Eq("last_name", newEmployee.LastName)
            );
            // set the new username and password and fix the role
            var update = Builders<Employee>.Update
                .Set("username", $"{newEmployee.FirstName.ToLower()}.{newEmployee.LastName.ToLower()}")
                .Set("password", HashPassword($"{newEmployee.FirstName.ToLower()}.{newEmployee.LastName.ToLower()}"))
                .Set("role", newEmployee.Role.ToString());

            // the actual update
            await employeeCollection.UpdateOneAsync(filter, update);
        }

        // this is just the method to hash password from the service layer
        // it needs to be used here but I think there must be a better way to do this
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