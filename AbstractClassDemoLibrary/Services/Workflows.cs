using AbstractClassDemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemoLibrary.Services
{
    internal static class Workflows
    {
        // method that simulates working day
        private static void EmployeeWorkflow(Employee employee)
        {
            employee.StartWork();

            employee.PerformTask("A", 1.5);
            employee.PerformTask("B", 4.5);

            employee.ShowTasksSummary();

            employee.FinishWork();
        }

        // method that creates objects and run EmployeeWorkflow method.
        public static void AbstractClassOverview()
        {
            // Compile time error - impossible to instantiate abstract class
            //Employee abstractEmployee = new Employee();

            // Creating list of Employee object, this work because Regular Employee and Manager
            // inherit from Employee class
            List<Employee> employees = new List<Employee>();
            employees.Add(new RegularEmployee("Patryk"));
            employees.Add(new Manager("Jan"));

            foreach (Employee employee in employees)
            {
                EmployeeWorkflow(employee);
                Console.WriteLine();
            }
        }
    }
}
