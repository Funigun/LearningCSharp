using TypeSystemDemo = TypeSystemDemoLibrary;
using ConcreteClass = ConcreteClassDemoLibrary;

namespace ConsoleUI
{
    internal class Menu
    {
        private Dictionary<int, string> _items;

        private Dictionary<int, Action> _actions;

        private sbyte _selectedView = -1;

        internal Menu()
        {
            _items = SetMenuItems();
            _actions = SetActions();
        }

        private Dictionary<int, string> SetMenuItems()
        {
            return new Dictionary<int, string>()
            {
                { 0, "0 - Close application" },
                
                { 1, "1 - Type System Demo - Value Types" },
                { 2, "2 - Type System Demo - Reference Types" },

                { 3, "3 - Concrete Class Demo - Overview" },
                { 4, "4 - Concrete Class Demo - Inheritance" },
                { 5, "5 - Concrete Class Demo - Operations order" }
            };
        }

        private Dictionary<int, Action> SetActions()
        {
            return new Dictionary<int, Action>
            {
                { 1, TypeSystemDemo.Workflows.ValueTypeWorkflow },
                { 2, TypeSystemDemo.Workflows.ReferenceTypeWorkflow },

                { 3, ConcreteClass.Workflows.ClassOverviewWorkflow },
                { 4, ConcreteClass.Workflows.ClassInheritanceWorkflow },
                { 5, ConcreteClass.Workflows.OperationsOrderWorkflow },
            };
        }

        private void ShowMenu()
        {
            foreach (string item in _items.Values)
            {
                Console.WriteLine(item);
            }
        }

        internal void Workflow()
        {
            do
            {
                Console.WriteLine("Welcome to Learning C# demo application.");
                Console.WriteLine($"Please choose view to show (number from 0 to {_items.Keys.Count - 1}):\n");
                
                ShowMenu();
                SelectViewToShow();

                if (_selectedView > 0)
                {
                    Console.Clear();
                    ShowView();
                    Console.WriteLine("Press any key to continue (this will clear current view).");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (_selectedView != 0);
        }

        private void SelectViewToShow()
        {
            do
            {
                try
                {
                    _selectedView = Convert.ToSByte(Console.ReadLine());
                }
                catch (Exception)
                {
                    _selectedView = -1;
                }

                if (_selectedView == -1 || _selectedView > _items.Keys.Count - 1)
                {
                    Console.WriteLine($"Provided value is not correct. Acceptable value is a number from 0 to {_items.Keys.Count - 1}.");
                }
            }
            while (_selectedView == -1);
        }

        private void ShowView() => _actions[_selectedView].Invoke();
        
    }
}
