using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteClassDemoLibrary
{
    public static class Menu
    {
        public static Dictionary<int, string> MenuList { get; private set; } = new Dictionary<int, string>()
        {
            { 1, "1 - Overview" },
            { 2, "2 - Inheritance" },
            { 3, "3 - Operations Order" }
        };

        public static Dictionary<int, Action> MenuActions { get; private set; } = new Dictionary<int, Action>()
        {
            { 1, Workflows.ClassOverviewWorkflow },
            { 2, Workflows.ClassInheritanceWorkflow },
            { 3, Workflows.OperationsOrderWorkflow }
        };
    }
}
