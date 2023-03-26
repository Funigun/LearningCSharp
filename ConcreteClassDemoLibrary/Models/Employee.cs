using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteClassDemoLibrary.Models
{
    internal class Employee
    {    // private field
        private double _workedHours;

        // Full Property:

        // private backing field
        private string _name;
        internal string Name
        {
            // when we read FirstName property we will get the first name in upper case
            get { return _name.ToUpper(); }
            set { _name = value; }
        }

        // Auto-Property
        internal string Position { get; set; }

        // Parameterles constructor
        // Default constructor when there is not a single constructor declared in the class
        internal Employee() 
        {
            Position = "Unassigned";
        }

        // Constructor that takes one argument and initialize value of the Name property
        // It also calls a parameterless constructor to set Position property
        internal Employee(string name) : this()
        {
            Name = name;
        }

        internal Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        // Methods that can not be overridden as they are not marked as virtual
        internal void PerformWork(double hoursWorked) => _workedHours += hoursWorked;

        internal void ReportHours() => Console.WriteLine($"{Name} Worked for: {_workedHours} hours");

        internal void StartWork() => Console.WriteLine($"{Name} started work.");
        

        // Virtual methods that can be overridden by derived classes
        internal virtual void Work() => Console.WriteLine($"{Name} processed assigned tasks.");
        
        internal virtual void FinishWork() => Console.WriteLine($"{Name} finished work.");
        
    }
}
