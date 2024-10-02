using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    [BsonIgnoreExtraElements]
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EmployeeId { get; private set; }
        [BsonElement("first_name")]
        public string FirstName { get; private set; }
        [BsonElement("last_name")]
        public string LastName { get; private set; }
        [BsonElement("email")]
        public string Email { get; private set; }
        [BsonElement("phone_number")]
        public string PhoneNumber { get; private set; }
        [BsonElement("role")]
        public EmployeeRole Role { get; private set; }
        [BsonElement("branch")]
        public string Branch { get; private set; }

        public Employee(string employeeId, string firstName, string lastName, string email, string phoneNumber, EmployeeRole role, string branch)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Role = role;
            Branch = branch;
        }
    }
}