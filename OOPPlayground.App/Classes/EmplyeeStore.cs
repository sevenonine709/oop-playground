using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPlayground.App.Classes
{
    public class EmplyeeStore : IEmplyeeStore
    {
        private List<Employee> employees;

        public EmplyeeStore()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DeleteEmployee(Guid id)
        {
            var employeeToREmove = employees.Find(x => x.Id == id);
            employees.Remove(employeeToREmove);
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(Guid id)
        {
            return employees.Find(x => x.Id == id);
        }
    }
}
