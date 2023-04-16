using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoLibrary.Models
{
    internal class Developer : IEmployee
    {
        public string Name { get; set; }
        public double WorkedHours { get; set; }

        internal Dictionary<string, double> PerformedTasks { get; set; } = new Dictionary<string, double>();

        public Developer(string name)
        {
            Name = name;
        }

        public void FinishWork() => Console.WriteLine($"{Name} finished work by sending code for review.");

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

        public void ReportHours() => Console.WriteLine("Sent hours to manager.");
        
        public void Break() => Console.WriteLine($"Developer {Name} takes a break.");
    }
}
