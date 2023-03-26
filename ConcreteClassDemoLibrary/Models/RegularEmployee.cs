using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteClassDemoLibrary.Models
{
    internal class RegularEmployee : Employee
    {
        public RegularEmployee(string name, string position) 
        {
            Name = name;
            Position = position;
        }

        // Class overrides Work method, but actually it's calling Employee.Work method using "base" keyword
        internal override void Work() => base.Work();

        // Class does not override FinishWork method.
        // We still can call this method and use implementation provided by Employee class.

    }
}
