using ConcreteClassDemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConcreteClassDemoLibrary
{
    public static class Workflows
    {
        public static void ClassOverviewWorkflow()
        {
            // Instantiating an object
            Employee employee = new Employee("Patryk");

            // Updating object property
            employee.Position = "Dev";

            // Calling object methods
            employee.StartWork();
            employee.PerformWork(4);
            employee.ReportHours();
            employee.FinishWork();
        }

        public static void ClassInheritanceWorkflow()
        {
            // Creating List of Employee objects, this is possibla, because
            // Manager and Regular Employee inherit from Employee class

            List<Employee> employees = new List<Employee>()
            {
                new Employee("Patryk", "Dev"),
                new Manager("Jan"),
                new RegularEmployee("Stefan", "Regular Employee")
            };

            
            foreach (Employee employee in employees)
            {
                employee.StartWork();

                // Reflection - reading object runtime type and casting Employee type to Manager type
                if (employee.GetType() == typeof(Manager))
                {
                    ((Manager)employee).AllocateTasks();
                }

                // Method outputs match implementations provided by proper class
                // regardless of iterating through them as Employee objects
                employee.PerformWork(4);
                employee.ReportHours();
                employee.FinishWork();
                Console.WriteLine();
            }
        }

        public static void OperationsOrderWorkflow()
        {
            Console.WriteLine("Calling \"Manager(string name) : base(name, \"Manager\")\" constructor.\n");
            
            Manager manager = new Manager("Patryk");

            Console.WriteLine("Operations order:");
            Console.WriteLine("1. Employee(string name, string position) constructor set both Name and Position properties.");
            Console.WriteLine("2. Manager constructor does nothing.");

            Console.WriteLine("\n");
            Console.WriteLine("Calling \"RegularEmployee(string name, string position)\" constructor.\n");
            
            RegularEmployee employee = new RegularEmployee("Patryk", "Dev");
            Console.WriteLine("Operations order:");
            Console.WriteLine("1. Employee() constructor set Position property value to \"Unassigned\".");
            Console.WriteLine("2. RegularEmployee set both Name and Position properties.\n");
            Console.WriteLine("WARNING: in this case RegularEmployee constructor overrides value provided by Employee constructor.");
        }
    }
}
