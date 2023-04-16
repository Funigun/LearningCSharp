using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemoLibrary.Services
{
    internal class CustomDelegateService
    {
        internal delegate void ShowMessage(string message);

        internal delegate double CalculateSalary(double workedHours);

        internal void ShowInformation(ShowMessage showMessage)
        {
            showMessage("Hello employee!");
        }

        internal void ShowCalculatedSalary(ShowMessage showMessage, CalculateSalary calculator, double workedHours)
        {
            double salary = calculator(workedHours);
            showMessage($"Your salary for {workedHours} working hours is: {salary}.");
        }
    }
}
