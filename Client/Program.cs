using System.ServiceModel;
using ServiceReference1;

Console.WriteLine("Hello, please enter Employment Id!");
var id = Console.ReadLine();

var client = new EmployeeServiceClient(EmployeeServiceClient.EndpointConfiguration.BasicHttpBinding_IEmployeeService, "http://localhost:5171/EmployeeService.svc");

var employee = await client.GetEmployeeAsync(Convert.ToInt16(id));

Console.WriteLine($"Employee Name : {employee.Name}");
Console.WriteLine($"Employee Position : {employee.Position}");
Console.WriteLine($"Employee Salary : {employee.Salary}");
Console.WriteLine($"Employee DateOfBirth : {employee.DateOfBirth}");

Console.ReadLine();