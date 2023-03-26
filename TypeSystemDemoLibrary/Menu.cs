using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemoLibrary
{
    public static class Menu
    {
        public static Dictionary<int, string> MenuList { get; private set; } = new Dictionary<int, string>()
        {
            { 1, "1 - Value Types" },
            { 2, "2 - Reference Types" }
        };

        public static Dictionary<int, Action> MenuActions { get; private set; } = new Dictionary<int, Action>()
        {
            { 1, Workflows.ValueTypeWorkflow },
            { 2, Workflows.ReferenceTypeWorkflow }
        };
    }
}
