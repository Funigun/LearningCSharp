using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemoLibrary.Services
{
    internal class EmployeeService
    {
        internal void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        internal double CalculateSalary(double workedHours)
        {
            double standardHours = workedHours > 8 ? 8 : workedHours;
            double overtimes = workedHours > 8 ? workedHours - 8 : 0;

            return Math.Round(standardHours * 10 + overtimes * 15, 2);
        }
    }
}
