using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemoLibrary.Models;

namespace InterfacesDemoLibrary.Services
{
    internal static class Workflows
    {
        private static void EmployeeWorkflow(IEmployee employee)
        {
            employee.StartWork();

            employee.PerformTask("A", 1.5);

            // Calling method for Developer object works fine as for other methods
            // Calling method for Manager object that has explicit implementation for IEmployee interface
            employee.Break();

            employee.PerformTask("B", 4.5);

            employee.FinishWork();
        }

        public static void InterfacesOverview()
        {
            // this will not work
            //IEmployee iEmployee = new IEmployee();

            Developer dev = new Developer("Patryk");
            Manager manager = new Manager("Jan");

            // calling "Break" method by 'Developer' type variable works
            //dev.Break();

            // calling "Break" method by 'Manager' type variable is impossible, beucase
            // it was implemented explicitly for interface
            //manager.Break();

            List<IEmployee> employees = new List<IEmployee>
            {
                dev,
                manager
            };

            foreach (IEmployee employee in employees)
            {
                EmployeeWorkflow(employee);
                Console.WriteLine();
            }
        }
    }
}
