using System;

namespace FluentValidationDemo.entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Job Job { get; set; } = new Job();
        public DateTime HiredDate { get; set; }
        public Location Location { get; set; } = new Location();
    }
}
