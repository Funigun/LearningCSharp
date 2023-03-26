using TypeSystemDemo = TypeSystemDemoLibrary;

namespace ConsoleUI
{
    internal class Menu
    {
        private Dictionary<int, string> _items;

        private sbyte _selectedView = -1;

        internal Menu()
        {
            _items = SetMenuItems();
        }

        private Dictionary<int, string> SetMenuItems()
        {
            return new Dictionary<int, string>()
            {
                { 0, "0 - Close application" },
                { 1, "1 - Type System Demo - Value Types" },
                { 2, "2 - Type System Demo - Reference Types" }
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

        private void ShowView()
        {
            switch (_selectedView)
            {
                case 1: 
                    TypeSystemDemo.Workflows.ValueTypeWorkflow(); 
                    break;

                case 2:
                    TypeSystemDemo.Workflows.ReferenceTypeWorkflow();
                    break;
            }
        }
    }
}
