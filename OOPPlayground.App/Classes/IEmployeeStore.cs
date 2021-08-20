using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPlayground.App.Classes
{
    public interface IEmplyeeStore
    {
        public Employee GetEmployeeById(Guid id);
        public List<Employee> GetAllEmployees();

        public void AddEmployee(Employee employee);
        public void DeleteEmployee(Guid id);
    }
}
