using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemoLibrary.Services
{
    internal class BuiltInDelegatesService
    {
        /*        
            There are 2 built-in generic delegates:
            
            - Action (return type void)
            - Func (return type specified by last generic type parameter)
        */

        internal void ShowInformation(Action<string> showMessage)
        {
            showMessage("Hello employee!");
        }

        internal void ShowCalculatedSalary(Action<string> showMessage, Func<double, double> calculator, double workedHours)
        {
            double salary = calculator(workedHours);
            showMessage($"Your salary for {workedHours} working hours is: {salary}.");
        }
    }
}
