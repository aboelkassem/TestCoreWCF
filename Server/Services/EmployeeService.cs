using Server.Models;

namespace Server.Services
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployee(int id)
        {
            return new Employee
            {
                Id = id,
                Name = "John Doe",
                DateOfBirth = DateTime.UtcNow,
                Position = "Developer",
                Salary = 15000
            };
        }

        public Employee[] GetEmployees()
        {
            return new[]
            {
                new Employee
                {
                    Id = 1,
                    Name = "John Doe",
                    DateOfBirth = DateTime.UtcNow,
                    Position = "Developer",
                    Salary = 15000
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane Doe",
                    DateOfBirth = DateTime.UtcNow,
                    Position = "Designer",
                    Salary = 15000
                }
            };
        }
    }
}
