using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemoLibrary.Models
{
    internal abstract class Employee
    {
        internal string Name { get; set; }
        internal double WorkedHours { get; set; }
        internal Dictionary<string, double> PerformedTasks { get; set; } = new Dictionary<string, double>();

        // Abstract class constructor should be marked as protected so only derived classes can use it
        protected Employee (string name)
        {
            Name = name;
        }

        // virtual methods that might be overwritten by derived class
        internal virtual void StartWork()
        {
            Console.WriteLine($"Started work from checking assigned tasks.");
        }

        internal virtual void FinishWork()
        {
            Console.WriteLine($"Finished work.");
        }

        // Classic methods, can not be overwritten by derived class, however it can be hidden by derived class 
        internal void PerformTask(string taskName, double hoursWorked)
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

        internal void ShowTasksSummary()
        {
            foreach (string task in PerformedTasks.Keys)
            {
                Console.WriteLine($"{task}: {PerformedTasks[task]} hours");
            }
            Console.WriteLine();
            Console.WriteLine($"Total hours worked: {WorkedHours}");
            Console.WriteLine();
        }

        // Abstract method, must be implemented by derived class
        internal abstract void RegisterHours();
    }
}
