using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoLibrary.Models
{
    internal interface IEmployee
    {
        string Name { get; set; }
        double WorkedHours { get; set; }

        // Default interface implementation
        void StartWork() => Console.WriteLine($"{Name} started work.");

        void FinishWork() => Console.WriteLine($"{Name} finished work.");

        void ReportHours();

        void PerformTask(string taskName, double hoursWorked);

        void Break();
    }
}
