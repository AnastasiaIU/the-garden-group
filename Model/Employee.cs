namespace Model
{
    public class Employee
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public EmployeeRole Role { get; private set; }
        public Branch Branch { get; private set; }

        public Employee(int id, string firstName, string lastName, string email, string phoneNumber, EmployeeRole role, Branch branch)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Role = role;
            Branch = branch;
        }
    }
}