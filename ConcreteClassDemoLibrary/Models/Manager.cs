using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteClassDemoLibrary.Models
{
    internal class Manager : Employee
    {
        internal Manager(string name) : base(name, "Manager") { }

        // Class overrides both Work and FinishWork method to provide it's own implementation
        internal override void Work() => Console.WriteLine($"{Name} assigned and verified tasks assigned to the team.");
        
        internal override void FinishWork() => Console.WriteLine($"{Name} created status report and finished work.");

        // Method that is exclusive to Manager, can not be called by Employee object
        internal void AllocateTasks() => Console.WriteLine("Allocated work within a team.");
    }
}
