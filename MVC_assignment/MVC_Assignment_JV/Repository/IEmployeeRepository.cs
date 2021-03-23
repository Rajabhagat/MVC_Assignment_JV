using System.Collections.Generic;

namespace MVC_Assignment_JV.Repository
{
    interface IEmployeeRepository
    {
       List<Models.Employee> SelectAllEmployee();
       Models.Employee SelectEmployeeById(int id);
       void UpdateEmployee(Models.Employee emp);
       void InsertEmployee(Models.Employee emp);
       void DeleteEmployee(int id);
       void UpdateEmployee(object emp);
    }
}
