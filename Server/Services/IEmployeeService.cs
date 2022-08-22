using Server.Models;

namespace Server.Services
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        public Employee GetEmployee(int id);

        [OperationContract]
        public Employee[] GetEmployees();
    }
}
