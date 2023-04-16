using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoLibrary.Models
{
    internal class Manager : IEmployee
    {
        public string Name { get; set; }
        public double WorkedHours { get; set; }

        internal Dictionary<string, double> PerformedTasks { get; set; } = new Dictionary<string, double>();

        public Manager(string name)
        {
            Name = name;
        }

        public void StartWork() => Console.WriteLine($"{Name} started work from assigning tasks.");

        public void PerformTask(string taskName, double hoursWorked)
        {
            if (PerformedTasks.ContainsKey(taskName))
            {
                PerformedTasks[taskName] += hoursWorked;
            }
            else
            {
                PerformedTasks.Add(taskName, hoursWorked);
            }

            WorkedHours += hoursWorked;
        }

        public void ReportHours()
        {
            Console.WriteLine("Inserting employees hours.");
            Console.WriteLine("Inserting own task summary report");
        }

        // Interface explicit implementation
        // this method can not be run by Manager type variable, but only by IEmployee type variable
        void IEmployee.Break() => Console.WriteLine($"Manager {Name} takes a break.");
    }
}
