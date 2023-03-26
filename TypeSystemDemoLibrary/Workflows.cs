using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemoLibrary
{
    public static class Workflows
    {
        public static void ValueTypeWorkflow()
        {
            int a = 5;
            int b = a; // Copying value of variable "a" to variable "b"

            b += 10;

            // variable "a" wasn't changed as int is a value type so below output will be:
            Console.WriteLine($"Value a: {a}");
            Console.WriteLine($"Value b: {b}");

            b = 7;

            // In case of passing value types as parameters, values are also being copied
            // This means that in current procedures values of variables "a" and "b" are still the same.
            int doubledSum = AddDoubledNumbers(a, b);
            Console.WriteLine($"Value a: {a}");
            Console.WriteLine($"Value b: {b}");
            Console.WriteLine($"Value doubledSum: {doubledSum}");
        }

        private static int AddDoubledNumbers(int a, int b)
        {
            a *= 2;
            b *= 2;

            return a + b;
        }

        public static void ReferenceTypeWorkflow()
        {
            Employee employee1 = new Employee("Patryk", "Dev");
            Employee employee2 = employee1; // Copying reference from variable "employee1" to variable "employee2"

            // At this point both variables point to the same object
            employee2.Position = "Dev";

            // Output is 2x Patryk - Dev
            Console.WriteLine(employee1);
            Console.WriteLine(employee2);

            // In this case we also pass only a reference of object
            UpdateEmployeePosition(employee2, "Senior Dev");

            // Output is 2x Patryk - Senior Dev
            // Explanation:
            // employee2 has been updated by UpdateEmployee method and both variables still point to the same object
            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
        }

        private static void UpdateEmployeePosition(Employee employee, string position)
        {
            employee.Position = position;
        }
    }
}
