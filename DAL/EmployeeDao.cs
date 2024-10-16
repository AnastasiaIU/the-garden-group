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

        //Orest
        //This method returns a list of all employees with the number of open tickets they have
        public async Task<List<Employee>> GetAllEmployeesWithCountedTicketsAsync()
        {
            var employeeDocument = await employeeCollection.Aggregate()
                .Lookup<Ticket, BsonDocument>(
                    "Ticket", //Join Employee with Ticket collection
                    "_id",
                    "service_desk_user",
                    @as: "Tickets" //Field name for the joined data
                )
                .Project<BsonDocument>(new BsonDocument
                {
                    { "EmployeeId", "$_id" },
                    { "FirstName", "$first_name" },
                    { "LastName", "$last_name" },
                    { "Email", "$email" },
                    { "PhoneNumber", "$phone_number" },
                    { "Role", "$role" },
                    { "Branch", "$branch" },
                    { "OpenTickets", new BsonDocument("$size", new BsonDocument(
                        "$filter", new BsonDocument
                        {
                            { "input", "$Tickets" },
                            { "as", "ticket" },
                            { "cond", new BsonDocument("$ne", new BsonArray { "$$ticket.Status", Status.Closed }) } //Count only open or in progress tickets
                        }))
                    }
                })
                .ToListAsync();

            // Map the BSON documents to Employee objects
            return MapToEmployee(employeeDocument);
        }

        //Orest
        // Method to map a list of BSON documents to a list of Employee objects
        private List<Employee> MapToEmployee(List<BsonDocument> employeeDocument)
        {
            // Select and turn each BSON document to a Employee object
            return employeeDocument.Select(doc => new Employee(
                doc["EmployeeId"].AsObjectId.ToString(),
                doc["FirstName"].AsString,
                doc["LastName"].AsString,
                doc["Email"].AsString,
                doc["PhoneNumber"].AsString,
                (EmployeeRole)Enum.Parse(typeof(EmployeeRole), doc["Role"].AsString),
                doc["Branch"].AsString,
                doc.Contains("OpenTickets") ? doc["OpenTickets"].ToInt32() : 0)
            ).ToList();
        }

        public async Task<Employee?> GetEmployeeByUsernameAndPasswordAsync(string username, string password)
        {
            var filter = Builders<Employee>.Filter.And(
            Builders<Employee>.Filter.Eq("username", username),
            Builders<Employee>.Filter.Eq("password", password)
            );
            return await employeeCollection.Find(filter).FirstOrDefaultAsync();
        }

        // Tina 
        // Deletes an employee from the databsae by their unique Id
        public async Task DeleteEmployeeByID(string employeeId)
        {
            await employeeCollection.DeleteOneAsync(SetFilterById(employeeId));
        }

        // Tina
        // Updates an employee's information by their unique Id
        public async Task UpdateEmployeeAsync(string employeeId, Employee updatedEmployee)
        {
            // Ensure the updated employee object keeps the original employee's Id
            updatedEmployee.ChangeEmployeeId(employeeId);

            // Replace the existing document with the updated employee object
            await employeeCollection.ReplaceOneAsync(SetFilterById(employeeId), updatedEmployee);
        }

        // Tina
        // Adds a new employee to the database
        public async Task CreateEmployeeAsync(Employee newEmployee, string username, string password)
        {
            // Insert the employee object into db
            await employeeCollection.InsertOneAsync(newEmployee);

            // Update the document with login credentials
            var update = Builders<Employee>.Update
                .Set("username", username)
                .Set("password", password);
            await employeeCollection.UpdateOneAsync(SetFilterById(newEmployee.EmployeeId), update);
        }

        // Tina
        // Generates a filter to find an employee by their ID
        private FilterDefinition<Employee> SetFilterById(string employeeId)
        {
            return Builders<Employee>.Filter.Eq("_id", new ObjectId(employeeId));
        }
    }
}
