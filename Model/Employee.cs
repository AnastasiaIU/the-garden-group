using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Model
{
    /// <summary>
    /// Represents an Employee entity stored in the MongoDB database. 
    /// This class defines the structure and fields of the employee document.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonIgnore]
        public string? EmployeeId { get; set; }

        [BsonElement("first_name")]
        public string FirstName { get; private set; }

        [BsonElement("last_name")]
        public string LastName { get; private set; }

        [BsonElement("email")]
        public string Email { get; private set; }

        [BsonElement("phone_number")]
        public string PhoneNumber { get; private set; }

        [BsonElement("role")]
        [BsonRepresentation(BsonType.String)] // making sure that the role is in text in db and not just the numerical value of enum
        public EmployeeRole Role { get; private set; }

        [BsonElement("branch")]
        public string Branch { get; private set; }

        [BsonIgnore]
        [JsonIgnore]
        public int? OpenTickets { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class with the specified details.
        /// </summary>
        /// <param name="firstName">The first name of the employee.</param>
        /// <param name="lastName">The last name of the employee.</param>
        /// <param name="email">The email address of the employee.</param>
        /// <param name="phoneNumber">The phone number of the employee.</param>
        /// <param name="role">The role of the employee.</param>
        /// <param name="branch">The branch where the employee is assigned.</param>
        /// <param name="openTickets">The number of open tickets associated with the employee (optional).</param>
        /// <param name="employeeId">The unique identifier of the employee (optional).</param>
        public Employee(string firstName, string lastName, string email, string phoneNumber, EmployeeRole role, string branch, int? openTickets = null, string? employeeId = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Role = role;
            Branch = branch;
            OpenTickets = openTickets;
            EmployeeId = employeeId;
        }
    }
}