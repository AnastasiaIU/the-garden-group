using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class EmployeeDao : BaseDao
    {
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
    }
}