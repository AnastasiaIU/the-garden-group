using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class EmployeeDao : BaseDao
    {
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            var employeeDocument = await employeeCollection.Aggregate()
                .Lookup<Ticket, BsonDocument>(
                    "Ticket",
                    "_id",
                    "service_desk_user",
                    @as: "Tickets"
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
                            { "cond", new BsonDocument("$ne", new BsonArray { "$$ticket.Status", Status.Closed }) }
                        }))
                    }
                })
                .ToListAsync();

            return MapToEmployee(employeeDocument);
        }

        private List<Employee> MapToEmployee(List<BsonDocument> employeeDocument)
        {
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