using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemoLibrary.Models
{
    internal class Manager : Employee
    {
        internal Manager(string name) : base(name) { }

        // overriding base class method, providing own implementation
        internal override void StartWork() => Console.WriteLine($"Started work from verifying tasks for other employees.");
        

        // Implementing abstract class RegisterHours method
        internal override void RegisterHours()
        {
            Console.WriteLine("Inserting employees hours.");
            Console.WriteLine("Inserting own task summary report");
        }
    }
}
