using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    /// <summary>
    /// Data Access Object (DAO) for managing Employee-related operations in the MongoDB database.
    /// </summary>
    public class EmployeeDao : BaseDao<Employee>
    {
        // Constants for referencing fields not included in the model
        private const string UsernameField = "username";
        private const string PasswordField = "password";

        #region Orest

        /// <summary>
        /// Asynchronously retrieves a list of all employees from the MongoDB collection.<para />
        /// Used in the API feature.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Employee"/> objects.</returns>
        public async Task<List<Employee>> GetAllEmployeesAPI()
        {
            var filter = Builders<Employee>.Filter.Empty;
            return await employeeCollection.Find(filter).ToListAsync();
        }

        /// <summary>
        /// Asyncronously updates an employee in the MongoDB collection by their unique ID.<para />
        /// Used in the API feature.
        /// </summary>
        public async Task UpdateEmployeeAPI(string id, Employee updatedEmployee)
        {
            updatedEmployee.EmployeeId = id;
            var filter = Builders<Employee>.Filter.Eq("_id", new ObjectId(id));
            await employeeCollection.ReplaceOneAsync(filter, updatedEmployee);
        }

        /// <summary>
        /// Asynchronously retrieves a list of all employees with the number of open or in-progress tickets they have.
        /// Tickets that are closed are excluded from the count.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing a list of <see cref="Employee"/> objects 
        /// with an additional field for counting open or in-progress tickets.</returns>
        public async Task<List<Employee>> GetAllEmployeesWithCountedTickets()
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

        /// <summary>
        /// Maps a list of BSON documents to a list of <see cref="Employee"/> objects.
        /// </summary>
        /// <param name="employeeDocument">A list of BSON documents representing employees and their ticket counts.</param>
        /// <returns>A list of <see cref="Employee"/> objects.</returns>
        private List<Employee> MapToEmployee(List<BsonDocument> employeeDocument)
        {
            // Select and convert each BSON document to an Employee object
            return employeeDocument.Select(doc => new Employee(
                doc["FirstName"].AsString,
                doc["LastName"].AsString,
                doc["Email"].AsString,
                doc["PhoneNumber"].AsString,
                (EmployeeRole)Enum.Parse(typeof(EmployeeRole), doc["Role"].AsString),
                doc["Branch"].AsString,
                doc.Contains("OpenTickets") ? doc["OpenTickets"].ToInt32() : 0,
                doc["EmployeeId"].AsObjectId.ToString())
            ).ToList();
        }

        #endregion

        #region Sia

        /// <summary>
        /// Asynchronously retrieves an employee by their username and password.
        /// </summary>
        /// <param name="username">The username of the employee.</param>
        /// <param name="password">The password of the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, containing the <see cref="Employee"/> object if found, otherwise null.</returns>
        public async Task<Employee?> GetEmployeeByUsernameAndPassword(string username, string password)
        {
            var filter = Builders<Employee>.Filter.And(
            Builders<Employee>.Filter.Eq(UsernameField, username),
            Builders<Employee>.Filter.Eq(PasswordField, password)
            );

            return await employeeCollection.Find(filter).FirstOrDefaultAsync();
        }

        #endregion

        #region Tina

        /// <summary>
        /// Asynchronously deletes an employee from the MongoDB collection by their unique ID.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee to delete.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task DeleteEmployeeByID(string employeeId)
        {
            await employeeCollection.DeleteOneAsync(GetFilterById(employeeId));
        }

        /// <summary>
        /// Asynchronously updates an employee's record in the MongoDB collection using the employee's ID from the provided object. 
        /// This method updates specific fields of the employee to ensure that sensitive information such as username and password 
        /// is preserved. A full replacement is avoided as it would overwrite these fields.
        /// </summary>
        /// <param name="updatedEmployee">The employee object containing the updated information.</param>
        /// <returns>A <see cref="Task"/> that represents the asynchronous operation of updating the employee's record.</returns>
        public async Task UpdateEmployeeAsync(Employee updatedEmployee)
        {
            // Defining only the fields that need to be updated to preserve sensitive fields like username and password
            var update = Builders<Employee>.Update
                .Set("first_name", updatedEmployee.FirstName)
                .Set("last_name", updatedEmployee.LastName)
                .Set("email", updatedEmployee.Email)
                .Set("phone_number", updatedEmployee.PhoneNumber)
                .Set("role", updatedEmployee.Role.ToString())
                .Set("branch", updatedEmployee.Branch);

            // Apply the update to the document, preserving username and password fields
            await employeeCollection.UpdateOneAsync(GetFilterById(updatedEmployee.EmployeeId), update);
        }

        /// <summary>
        /// Asynchronously adds a new employee to the MongoDB collection, along with their username and password for login.
        /// </summary>
        /// <param name="newEmployee">The new employee object to be added.</param>
        /// <param name="username">The username to be associated with the employee.</param>
        /// <param name="password">The password to be associated with the employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task CreateEmployeeAsync(Employee newEmployee, string username, string password)
        {
            // Insert the employee object into the collection
            await employeeCollection.InsertOneAsync(newEmployee);

            // Update the document with login credentials
            var update = Builders<Employee>.Update
                .Set("username", username)
                .Set("password", password);

            await employeeCollection.UpdateOneAsync(GetFilterById(newEmployee.EmployeeId), update);
        }

        /// <summary>
        /// Generates a filter to find an employee by their unique ID.
        /// </summary>
        /// <param name="employeeId">The unique ID of the employee.</param>
        /// <returns>A filter definition used for MongoDB queries.</returns>
        private FilterDefinition<Employee> GetFilterById(string employeeId)
        {
            return Builders<Employee>.Filter.Eq("_id", new ObjectId(employeeId));
        }

        #endregion
    }
}