using OOPPlayground.App.Classes;
using System;

namespace OOPPlayground.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ferenc = new Employee("Ferenc", "Pato");

            // ferenc.FirstName = "Ferenc";
            // ferenc.LastName = "Pato";

            IEmplyeeStore store = new EmplyeeStore();
            
            store.AddEmployee(ferenc);
            
            var randomId = Guid.NewGuid();
            var secondEmployee = new Employee("Donald", "Trump");
            secondEmployee.Id = randomId;
            store.AddEmployee(secondEmployee);

            store.AddEmployee(new Employee("Hillary", "Clinton"));

            var allEmployees = store.GetAllEmployees();

            var donaldTrump = store.GetEmployeeById(randomId);

            Employee.GetSomeRandomString();

            Console.WriteLine("The count of employees: " + allEmployees.Count);
            foreach (var employee in allEmployees)
            {
                Console.WriteLine("The employee: " + employee.GetUserSerialized());
            }
            Console.WriteLine("Query result: " + donaldTrump.GetUserSerialized());
        }
    }
}
