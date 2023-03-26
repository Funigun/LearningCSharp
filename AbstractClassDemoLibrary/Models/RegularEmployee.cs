using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemoLibrary.Models
{
    internal class RegularEmployee : Employee
    {
        public RegularEmployee(string name) : base(name) { }

        // overriding base class method, but actually calling the base class implementation
        internal override void StartWork()
        {
            base.StartWork();
        }

        // Implementing abstract class RegisterHours method
        internal override void RegisterHours() => Console.WriteLine($"Sending tasks summary report to superior.");
        
    }
}
