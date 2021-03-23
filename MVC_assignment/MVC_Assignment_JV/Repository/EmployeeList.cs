using MVC_Assignment_JV.Models;
using System.Collections.Generic;

namespace MVC_Assignment_JV.Repository
{
    public static class EmployeeList
    {
        static List<Employee> emplist = null;

        static EmployeeList()
        {
            emplist = new List<Employee>()
            {
                new Employee
                {
                    EmployeeCode= 1,
                    FirstName = "Salahuddin",
                    LastName = "Ahmed",
                    YearsOfExperience = 2,
                    Email = "SA@g.com",
                    PhoneNumber= 99999999
                }
            };
        }


        public static List<Employee> SelectEmployeeList()
        {
            return emplist;
        }

        public static void InsertEmployeeList(Employee emp)
        {
            emplist.Add(emp);
        }

        public static void UpdateEmployeeList(Employee emp)
        {
            Employee empUpdate = emplist.Find(x => x.EmployeeCode == emp.EmployeeCode);
            empUpdate.FirstName = emp.FirstName;
            empUpdate.LastName = emp.LastName;
            empUpdate.Email = emp.Email;
            empUpdate.PhoneNumber = emp.PhoneNumber;
            empUpdate.YearsOfExperience = emp.YearsOfExperience;
        }

        public static void DeleteEmployeeList(int id)
        {
            Employee empDelete = emplist.Find(x => x.EmployeeCode == id);
            emplist.Remove(empDelete);
        }
    }
}