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
        [BsonRepresentation(BsonType.String)] // making sure that the role is in text in db and not just the numerical value of enum
        public EmployeeRole Role { get; private set; }
        [BsonElement("branch")]
        public string Branch { get; private set; }
        [BsonIgnore]
        public int? OpenTickets { get; set; }

        public Employee(string employeeId, string firstName, string lastName, string email, string phoneNumber, EmployeeRole role, string branch, int? openTickets = null)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Role = role;
            Branch = branch;
            OpenTickets = openTickets;
        }
        //Tina
        public Employee(string firstName, string lastName, string email, string phoneNumber, EmployeeRole role, string branch)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Role = role;
            Branch = branch;
        }
    }
}